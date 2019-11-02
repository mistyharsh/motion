export default {
  build: {
    extend(config, { isDev, isClient }) {

      // Add F# code via fable-loader
      config.module.rules.push({
        test: /\.fs(x|proj)?$/,
        use: 'fable-loader'
      });


    }
  }
}
