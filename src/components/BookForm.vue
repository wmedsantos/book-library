<template>
  <div class="container mt-4">
    <h2>{{ localBook.id ? 'Edit Book' : 'Add Book' }}</h2>
    <b-form @submit.prevent="saveBook">
      <b-form-group label="Title:" label-for="title">
        <b-form-input id="title" v-model="localBook.title" required></b-form-input>
      </b-form-group>
      <b-form-group label="Author:" label-for="author">
        <b-form-input id="author" v-model="localBook.author" required></b-form-input>
      </b-form-group>
      <b-form-group label="ISBN:" label-for="isbn">
        <b-form-input id="isbn" v-model="localBook.isbn" required></b-form-input>
      </b-form-group>
      <b-form-group label="Published Date:" label-for="publishedDate">
        <b-form-input type="date" id="publishedDate" v-model="localBook.publishedDate" required></b-form-input>
      </b-form-group>
      <b-button type="submit" variant="primary">{{ localBook.id ? 'Update' : 'Add' }}</b-button>
      <b-button type="button" variant="secondary" @click="$emit('close')">Cancel</b-button>
    </b-form>
  </div>
</template>
  
  <script>
  import BookService from '@/services/BookService';
  
  export default {
    props: {
      book: {
        type: Object,
        default: () => ({
          id: '',
          title: '',
          author: '',
          isbn: '',
          publishedDate: ''
        })
      }
    },
    data() {
      return {
        localBook: { ...this.book }
      };
    },
    watch: {
      book: {
        handler(newBook) {
          this.localBook = { ...newBook };
          this.localBook.publishedDate = this.formatDate(newBook.publishedDate);
        },
        deep: true,
        immediate: true
      }
    },
    methods: {
      formatDate(date) {
      if (!date) return '';
      const d = new Date(date);
      const month = ('0' + (d.getMonth() + 1)).slice(-2);
      const day = ('0' + d.getDate()).slice(-2);
      const year = d.getFullYear();
      return `${year}-${month}-${day}`;
    },
      saveBook() {
        if (this.localBook.id) {
          BookService.updateBook(this.localBook.id, this.localBook).then(() => {
            this.$emit('save');
            this.$emit('close');
          });
        } else {
          BookService.addBook(this.localBook).then(() => {
            this.$emit('save');
            this.$emit('close');
          });
        }
      }
    }
  };
  </script>