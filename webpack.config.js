const path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin')


module.exports = {

  context: __dirname,

  mode: 'development',
  devtool: 'eval',

  entry: {
    app: './src/app/main.js'
  },

  output: {
    path: path.join(__dirname, './dist'),
    filename: '[name].[hash].bundle.js'
  },

  module: {
    rules: [
      {
        test: /\.svelte$/,
        exclude: /node_modules/,
        use: 'svelte-loader'
      },
      {
        test: /\.fs(x|proj)?$/,
        use: 'fable-loader'
      }
    ]
  },

  plugins: [
    new HtmlWebpackPlugin({
      title: 'Motion with F#',

    })
  ],

  resolve: {
    // ensures that only one copy of svelte included in the application
    alias: {
      svelte: path.resolve('node_modules', 'svelte')
    },


    extensions: ['.mjs', '.js', '.svelte'],
    mainFields: ['svelte', 'browser', 'module', 'main']
  },

  devServer: {
    contentBase: './dist',
    port: 8080
  }

};
