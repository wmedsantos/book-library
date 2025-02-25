# Book Library Application

## Overview

The Book Library Application is a full-stack web application that allows users to manage a collection of books. Users can add, edit, delete, and view books in the library. The application is built using modern web technologies and is deployed on Azure.

## Technologies Used

### Frontend

- **Vue.js**: A progressive JavaScript framework for building user interfaces.
- **BootstrapVue 3**: A Vue.js implementation of Bootstrap for responsive and mobile-first web development.
- **Axios**: A promise-based HTTP client for making API requests.

### Backend

- **ASP.NET Core**: A cross-platform, high-performance framework for building modern, cloud-based, Internet-connected applications.
- **MongoDB**: A NoSQL database for storing book data.
- **Swagger**: A tool for documenting and testing APIs.

### Deployment

- **Azure App Service**: The backend is deployed on Azure App Service, which provides a scalable and secure environment for hosting web applications.
- **Azure Static Web Apps**: The frontend is deployed on Azure Static Web Apps, which provides a streamlined and secure way to host static web applications.

## Project Setup

### Frontend

1. Navigate to the `Frontend/book-library-frontend` directory.
2. Install the dependencies:

    ```sh
    npm install
    ```

3. Compiles and hot-reloads for development:

    ```sh
    npm run serve
    ```

4. Compiles and minifies for production:

    ```sh
    npm run build
    ```

5. Lints and fixes files:

    ```sh
    npm run lint
    ```

### Backend

1. Navigate to the `Backend` directory.
2. Restore the dependencies:

    ```sh
    dotnet restore
    ```

3. Build the project:

    ```sh
    dotnet build
    ```

4. Run the project:

    ```sh
    dotnet run
    ```

## Deployment

### Frontend

The frontend is deployed on Azure Static Web Apps. You can access the live site at [Book Library Frontend](https://wonderful-dune-006d2720f.4.azurestaticapps.net/).

### Backend

The backend is deployed on Azure App Service. The API endpoints are available at `https://booklibrary-eugcaphkc3h3gmhq.brazilsouth-01.azurewebsites.net/api/books`.

## API Endpoints

- **GET /api/books**: Retrieve all books.
- **GET /api/books/{id}**: Retrieve a book by ID.
- **POST /api/books**: Add a new book.
- **PUT /api/books/{id}**: Update a book by ID.
- **DELETE /api/books/{id}**: Delete a book by ID.

## Links

- **Frontend**: [Book Library Frontend](https://wonderful-dune-006d2720f.4.azurestaticapps.net/)
- **Backend API**: `https://booklibrary-eugcaphkc3h3gmhq.brazilsouth-01.azurewebsites.net/api/books`

## Customize Configuration

See [Configuration Reference](https://cli.vuejs.org/config/).

## License

This project is licensed under the MIT License.