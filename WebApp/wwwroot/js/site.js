document.addEventListener('DOMContentLoaded', function () {
    handleProfileImageUpload()
})

function handleProfileImageUpload() {
    try {

        let fileUploader = document.querySelector('#fileUploader')
        if (fileUploader != null) {
            fileUploader.addEventListener('change', function () {
                if (this.files.length > 0) {
                    this.form.submit()
                }
            })
        }
    }
    catch (error)
    {
        console.error('Error handling profile image upload:', error);
    }
}