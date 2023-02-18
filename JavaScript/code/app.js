// let language="java Script";
// console.log(language);

// const addition=(a,b)=>{
//     console.log(a+b);

// };
// addition(3,4);

// const addition=(a)=> console.log(a+a);
// const addition=a=> console.log(a+a);
// addition(3);

//for window object
//console.log(this); 

// const shop={
//     purchase:()=>
//     {
//         console.log(this)
//     }
// }
// shop.purchase();

// const muButton=document.querySelector('#myButton');

// const shop={
//     price:1000,
//     buy: function(){
//         // const self=this;
//         //also use cont _this=this;
//         // myButton.addEventListener('click',function()
//         myButton.addEventListener('click',()=>
//         {
//            console.log('I spent'+this.price);   
//             //   console.log('I spent '+self.price);
//         })

//     }
// } 

// shop.buy();

//template literals AKA . BACKTICKS

// const fistName='Rakesh';
// const lastName='Sharma';

// console.log(fistName+''+lastName);

// hello 

// how are you

// const message='hello \n' + 'how are you';

//back ticks (``) use for multiple lines

// const name=Rakesh;

// const message=`hello ${name}
    
//    how are you
// `;
// console.log(message);




//Enhanced object literals

// conputed property keys [use name]

//method defination shortHand

//property short hand

//const keyName='name';
// const product={
//     // [keyName]:'Mobile',
//     // price:500,
//     // buy:function(){
//         buy(){             //methos defination short hand
//         console.log('Bought');
//     },
// };
// console.log(product.buy());





//property short hand
// const accessToken='qwertyjk';
// const refereshToken='wertyu';

// const user=
// {
// //     accessToken:accessToken,           //same name 
// //     refereshToken:refereshToken,
//     accessToken,
//     refereshToken,
// }

// console.log(user);






//Destructuring 

// const user=
// {
//     name:'johs',
//     age:34,
// }

// // const {name:fullname,age} =user;
// const name=user.name;
// const age=user.age;
// // console.log(user.name)


// const data=['Rakesh','Saurabh','Santosh']

// const [name,name2,name3]=data;

// console.log(name,name2,name3);

// const [count,setcount]=useState();




//default parameters


// const register=(name,password,image='img.png')=>
// {
//     // const img= image||image.jpg;
// //   console.log(name,password,img);
//    console.log(name,password,image);
// }

// register('Rakesh','secret');





//spread...



// const language=['c','c++','java']

// const newlanguage=[javaScript,...language,'python']

// console.log(newlanguage);


// const settings={
//     volumn:10,
// }

// const newsettings={...settings,contrast:40};
// console.log(settings);
// console.log(newsettings);


//rest ... basicly it is used with functions


// const addItems=(...items)=>
// {
//     console.log(items);
// };

// addItems(12,23,34,44,56);




//for of loop

//array, string,object,set, map

// const numbers=[1,2,3,4];
// for(const num of numbers)
// {
//     console.log(num);
// };

// const language ='javaScript';
// for(const string of language){
//     console.log(string);

// }


// use forof when create a object

// const person ={
//     name:'Rakesh',
//     age:35,
//     designation:'Developer'
// }

// // for(const details of person)   // in a object ceration it is not works 
//  for(const [key,value] of Object.entries(person)) 
// //  for(const details of Object.entries(person)) 
// {
//     console.log(key,value);
//     // console.log(details);
// }


//promises  //asynchronous


// function login(){
//     setTimeout(()=>{
     
//         console.log('login...');
//     },0);
// }

// login();
// console.log( 'not a login first');



//with the help of callBack we can call normal value before the login call



// function login(cb){
//     setTimeout(()=>{
     
//         console.log('login...');
//         cb();
//     },0);
// }

// login(()=>{

//     console.log( 'not a login first');
// });



// function login()
// {
//     return new Promise((resolve,reject)=>{

//         setTimeout(()=>{
//             console.log('login....');

//             resolve();
//             //if any error then use reject();then block is not run catch block is run 
        
//            },0);

//     });
   
// }
// login().then(()=>
// {
//     console.log('Register');
// }).catch((error)=>
// {
//     console.log('error...');
// }
// );



//find method(Array method)


// const users =[{name:'Rohit'},{name:'Rohan'}];
// const user =users.find((user)=>{
//     return user.name==='Rohit';
// })

// console.log(user);



//find index

//when not a found a index in array then show result -1

// const users =[{name:'Rohit'},{name:'Rohan'}];
// const user =users.findIndex((user)=>{
//     return user.name==='Rohit';
// })

// console.log(user);




//set   ?in a set defines a unique items?


// const uniquenumbers=new Set();

// uniquenumbers.add(3);
// uniquenumbers.add(4);
// uniquenumbers.add(5);
// uniquenumbers.add(6);
// uniquenumbers.add(3);

// console.log(uniquenumbers);
// console.log(uniquenumbers.has());

// const numbers =[4,5,6,4,5];
// const uniqueNumbers =new Set(numbers);
// console.log(Array.from(uniqueNumbers));
// //or
// // console.log(uniqueNumbers);


//map (HashTables)

//Big O Notation  // 0(1) // for searching very fast 

// const urls=new Map();
// urls.set('developer','dev.developers.com');
// urls.set('Engineer','Eng.Engineer.com');

// // for(const url of urls)
// // {
// //    console.log(url);
// // }




// for(const [key,value] of urls)
// {
//    console.log(key,value);
// }


// console.log(urls.size);

// console.log(urls.get('production'));


//normal objects 

// const urlsObj={
//     developer:'this is dev',
//     engineer:'this is engineer',
// }

// console.log(urlsObj.developer);


//classes

//constructions functions


// old method wehn create a object and constructor

// function Person(name) {
//     this.name=name;

// }
// const rakesh =new Person('adem');
// const john =new Person('balck');
 
// rakesh.name='gyan';

// console.log(john);



// class Person{
//     name;

//     constructor(name)
//     {
//        this.name=name;
//     } 

//     greet()
//     {
//         console.log('hello....vie');
//     }
// }


// //inheritance 
// class GreatePerson extends Person
// {
//     attitude='cool';

//      //over ride
//     greet()
//     {
//         console.log('hello....good evening');
//     }

// }

// const rakesh =new Person('Rakesh');
// //const jon =new Person('jon');
// const jon =new GreatePerson('jon');
// console.log(jon);
// console.log(rakesh.greet());






//ES6 modules




// import {libName} from './lib.js';
import {libName as myLibname} from './lib.js';

import myLogin from './lib.js';
myLogin();

// console.log(libName);
console.log(myLibname);