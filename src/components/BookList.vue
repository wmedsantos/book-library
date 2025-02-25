<template>
  <div class="container mt-4">
    <h1>Vue Book List</h1>
    <b-table striped hover :items="books" :fields="fields">
      <template #cell(actions)="row">
        <b-button size="sm" variant="warning" @click="editBook(row.item)">Edit</b-button>
        <b-button size="sm" variant="danger" @click="deleteBook(row.item.id)">Delete</b-button>
      </template>
    </b-table>
    <b-button variant="primary" @click="showAddBookForm = true">Add Book</b-button>
    <BookForm v-if="showAddBookForm" @close="showAddBookForm = false" @save="fetchBooks" />
    <BookForm v-if="selectedBook" :book="selectedBook" @close="selectedBook = null" @save="fetchBooks" />
  </div>
</template>


<script>
import BookService from '@/services/BookService';
import BookForm from './BookForm.vue';

export default {
  data() {
    return {
      books: [],
      showAddBookForm: false,
      selectedBook: null,
      fields: [
        { key: 'title', label: 'Title' },
        { key: 'author', label: 'Author' },
        { key: 'isbn', label: 'ISBN' },
        { key: 'publishedDate', label: 'Published Date' },
        { key: 'actions', label: 'Actions' }
      ]
    };
  },
  components: {
    BookForm
  },
  created() {
    this.fetchBooks();
  },
  methods: {
    fetchBooks() {
      BookService.getAllBooks().then(response => {
        this.books = response.data;
      });
    },
    editBook(book) {
      this.selectedBook = book;
    },
    deleteBook(id) {
      BookService.deleteBook(id).then(() => {
        this.fetchBooks();
      });
    }
  }
};
</script>