import App from './App.svelte';

import * as X from '../Motion/Library.fs';

console.log(X);

function bootstrapApplication(element) {

  const _app = new App({
    target: element,
    props: { }
  });

}


window.addEventListener('DOMContentLoaded', () => {

  const rootElm = document.createElement('div');

  rootElm.classList.add('app');

  document.body.appendChild(rootElm);

  bootstrapApplication(rootElm);

});