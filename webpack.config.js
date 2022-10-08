const path = require('path');
const autoprefixer = require('autoprefixer');

module.exports = {
    rules: [
        {
          test: /\.js$/,
          /* ... */
        },
        {
          // Apply rule for .sass, .scss or .css files
          test: /\.(sa|sc|c)ss$/,
    
          // Set loaders to transform files.
          // Loaders are applying from right to left(!)
          // The first loader will be applied after others
          use: [
                 {
                   // This loader resolves url() and @imports inside CSS
                   loader: "css-loader",
                 },
                 {
                   // Then we apply postCSS fixes like autoprefixer and minifying
                   loader: "postcss-loader"
                 },
                 {
                   // First we transform SASS to standard CSS
                   loader: "sass-loader",
                   options: {
                     implementation: require("sass")
                   }
                 }
               ]
        }
    ]
}