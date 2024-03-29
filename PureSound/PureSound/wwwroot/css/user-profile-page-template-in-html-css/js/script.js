(() => {

    'use-strict'

    const themeSwiter = {

        init: function () {
            this.wrapper = document.getElementById('theme-switcher-wrapper')
            this.button = document.getElementById('theme-switcher-button')
            this.theme = this.wrapper.querySelectorAll('[data-theme]')
            this.themes = ['theme-orange', 'theme-purple', 'theme-green', 'theme-blue']
            this.events()
            this.start()
        },

        events: function () {
            this.button.addEventListener('click', this.displayed.bind(this), false)
            this.theme.forEach(theme => theme.addEventListener('click', this.themed.bind(this), false))
        },

        start: function () {
            let theme = this.themes[Math.floor(Math.random() * this.themes.length)]
            document.body.classList.add(theme)
            this.setButtonColor(theme);
        },

        displayed: function () {
            (this.wrapper.classList.contains('is-open'))
                ? this.wrapper.classList.remove('is-open')
                : this.wrapper.classList.add('is-open')
        },

        themed: function (e) {
            const selectedTheme = e.currentTarget.dataset.theme;
            this.themes.forEach(theme => {
                if (document.body.classList.contains(theme))
                    document.body.classList.remove(theme)
            })
            document.body.classList.add(`theme-${selectedTheme}`);
            this.setButtonColor(`theme-${selectedTheme}`);
        },

        setButtonColor: function (themeClass) {
            const button = document.querySelector('.genric-btn');
            button.classList.remove('warning', 'info', 'primary', 'success');
            switch (themeClass) {
                case 'theme-orange':
                    button.classList.add('warning');
                    break;
                case 'theme-purple':
                    button.classList.add('info');
                    break;
                case 'theme-green':
                    button.classList.add('success');
                    break;
                case 'theme-blue':
                    button.classList.add('primary');
                    break;
                default:
                    button.classList.add('warning'); // Default color
            }
        }

    }

    themeSwiter.init()

})()
