const button = document.getElementById('toggleButton');

let clickCount = localStorage.getItem('clickCount') || 0;
button.classList.toggle('clicked', clickCount % 2 === 0);

button.addEventListener('click', function () {
    clickCount++;
    localStorage.setItem('clickCount', clickCount);
    const isEvenClick = clickCount % 2 === 0;

    let token = $('input[name="__RequestVerificationToken"]').val();

    let id = button.firstElementChild.id;
    let formData = new FormData();
    formData.append("id", id);
    if (isEvenClick) {
        $.ajax({
            url: '/Tracks/RemoveFromFavourite',
            type: 'POST',
            data: formData,
            contentType: false,
            processData: false,
            headers: {
                "RequestVerificationToken": token
            },
            success: function (response) {
                console.log('Second action successful');
            },
            error: function (xhr, status, error) {
                console.error('Error executing second action:', error);
            }
        });
    } else {
        $.ajax({
            url: '/Tracks/AddToFavourite',
            type: 'POST',
            data: formData,
            contentType: false,
            processData: false,
            headers: {
                "RequestVerificationToken": token
            },
            success: function (response) {
                console.log('First action successful');
            },
            error: function (xhr, status, error) {
                console.error('Error executing first action:', error);
            }
        });
    }

    button.classList.toggle('clicked', isEvenClick);
});