.. code-block:: kotlin

   app.emailPassword.sendResetPasswordEmailAsync(email) {
       if (it.isSuccess) {
           Log.i("EXAMPLE", "Successfully sent the user a reset password link to $email")
       } else {
           Log.e("EXAMPLE", "Failed to send the user a reset password link to $email: $it.error")
       }
   }
