import axios from 'axios';

const API_URL = 'https://localhost:7208/api/books';

class BookService {
    getAllBooks() {
        return axios.get(API_URL);
    }

    getBookById(id) {
        return axios.get(`${API_URL}/${id}`);
    }

    addBook(book) {
        return axios.post(API_URL, book);
    }

    updateBook(id, book) {
        return axios.put(`${API_URL}/${id}`, book);
    }

    deleteBook(id) {
        return axios.delete(`${API_URL}/${id}`);
    }
}

export default new BookService();