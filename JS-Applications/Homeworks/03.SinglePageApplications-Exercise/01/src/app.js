import {setupHome, showHome} from './home.js';
import {setupCreate, showCreate} from './create.js';
import {setupPost} from './post.js';

const main = document.querySelector('main');

setupSection('home-topics', setupHome);
setupSection('create-topic', setupCreate);
setupSection('post-with-comments', setupPost);

function setupSection(sectionId, setup){
    const section = document.getElementById(sectionId);
    setup(main, section);
}

showHome();

document.querySelector('#home-link').addEventListener('click', showHome);