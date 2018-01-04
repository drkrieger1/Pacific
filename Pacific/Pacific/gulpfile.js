/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');

gulp.task('compile-sass', function () {

    // place code for your default task here
    gulp.src('./wwwroot/lib/bootstrap/scss/bootstrap.scss')
        .pipe(gulp())

        .pipe(gulp.dest('./wwwroot/css')); 

});