(function () {
    var divBookList = new Vue({
        el: '#divBookList',
        data: {
            errors: [],
            books: []
        },
        methods: {
            load: function (cb) {
                var self = this;

                //console.log(self);
                loadBooks(self);
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
            console.log(response);
            self.books = response;
        }).fail(function (xhr) {
            if (console)
                console.log(xhr);

            self.errors = ['Não foi possivel carregar os dados, tente novamente!'];
        });
    }

})();