(function () {
    var divBookList = new Vue({
        el: '#divBookList',
        data: {
            errors: [],
            modalErrors: [],
            livros: [],
            livro: {}
        },
        methods: {
            load: function () {
                var self = this;

                loadBooks(self);
            },
            newBook: function () {
                clearFields(this);
                showModal('#divBookForm');
            },
            add: function () {
                var self = this;

                saveBook(self);
            },
            edit: function (index) {
                var self = this;

                editBook(self, index);
            },
            remove: function (index) {
                var self = this;

                deleteBook(self, index);
            },
            cancel: function () {
                var self = this;

                clearFields(self);
                closeModal('#divBookForm');
            }
        },
        mounted: function () {
            var self = this;
            self.load();
        }
    });

    function loadBooks(self) {
        $.get({
            url: '/Home/List'
        }).done(function (response) {
            self.livros = response;
        }).fail(function (xhr) {
            if (console)
                console.log(xhr);

            self.errors = ['Não foi possivel carregar os dados, tente novamente!'];
        });
    }

    function saveBook(self) {
        $.post({
            url: '/Home/Save',
            data: self.livro
        }).done(function (result) {

            if (result.data.Id !== 0) {
                self.load();
                clearFields(self);
                closeModal('#divBookForm');
            }
            else if (result.errors.length > 0) {
                self.modalErrors = result.errors;
            }

        }).fail(function (xhr) {
            if (console)
                console.log(xhr);

            self.modalErrors = ['Não foi possível realizar esta ação, tente novamente!'];
        });
    }

    function editBook(self, index) {
        self.livro = JSON.parse(JSON.stringify(self.livros[index]));
        self.livro.DataPublicacao = moment(self.livro.DataPublicacao).format('YYYY-MM-DD');
        showModal('#divBookForm');
    }

    function deleteBook(self, index) {
        var livro = self.livros[index];

        $.post({
            url: '/Home/Delete',
            data: { id: livro.Id }
        }).done(function () {
            self.livros.splice(index, 1);
        }).fail(function (xhr) {
            if (console)
                console.log(xhr);

            self.modalErrors = ['Não foi possível realizar esta ação, tente novamente!'];
        });
    }

    function clearFields(self) {
        self.livro = {};
    }

    function showModal(selector) {
        $(selector).modal('show');
    }

    function closeModal(selector) {
        $(selector).modal('hide');
    }    
})();