const { heroes } = require('./data.js');

//The .find() method will return the frst element in the array that matches a test you provide.
function isHulk(hero) {
    return hero.name === 'Hulk';
   }
var hulk = heroes.find(isHulk);

console.log(hulk);
//expected output
//{ name: 'Hulk', strength: 90000 }