var validator = new FormValidator('registerForm', [{
    name: 'name',
    display: 'required',
    rules: 'required|alpha'
}, {
    name: 'company',
    rules: 'alpha_numeric|required'
}, {
    name: 'email',
    rules: 'required|valid_email'
}, {
    name: 'password',
    rules: 'required|min_length[8]'
}, {
    name: 'email',
    rules: 'valid_email',
    depends: function () {
        return Math.random() > .5;
    }
}, {
    name: 'code',
    rules: 'required|numeric|max_length[3]'
}, {
    name: 'number',
    rules: 'required|numeric|max_length[7]'
}
]);