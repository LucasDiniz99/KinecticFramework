{
    test: /\.(sa|sc|c)ss$/,
    use: [
            {
                loader: 'style-loader',
                options: {
                    hmr: true
                }
            },
            {
                loader: 'css-loader',
                options: {
                   modules: true,
                   importLoaders: 1,
                   localIdentName: '[name]__[local]___[hash:base64:5]',
                },
           },
           {
               loader: 'postcss-loader',
               options: {
                   plugins: [autoprefixer({ browsers: ['> 1%'] })]
               },
            },
            'sass-loader'
        ],
}