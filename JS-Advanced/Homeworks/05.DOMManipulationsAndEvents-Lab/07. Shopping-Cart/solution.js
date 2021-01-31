function solve() {
   const textElement = document.querySelector('div[class="shopping-cart"]>textarea');
   const products = document.querySelectorAll('div[class="product"]');
   const checkoutButton = document.querySelector('div[class="shopping-cart"]>button');
   const list = {};

   checkoutButton.addEventListener('click', onCheckout);

   document.querySelector('div[class="shopping-cart"]').addEventListener('click', addProduct);

   /*for(let product of products){
      const addButton = product.querySelector('div[class="product-add"] > button');

      addButton.addEventListener('click', addProduct);
   }*/

   function addProduct(ev) {

      if (ev.target.tagName == 'BUTTON' && ev.target.className == 'add-product') {
         const productNode = ev.target.parentNode.parentNode

         const name = productNode.querySelector('div[class="product-details"] > .product-title').textContent;
         const price = Number(productNode.children[3].textContent);

         if (list[name] == undefined) {
            list[name] = 0;
         }
         list[name] += price;

         textElement.textContent += `Added ${name} for ${price.toFixed(2)} to the cart.\n`;
      }

   }

   function onCheckout(ev) {
      const productsArr = Object.keys(list);
      const boughtProducts = productsArr.reduce((acc, c, i) => {
         if (i == productsArr.length - 1) {
            return acc += `${c}`;
         }

         return acc += `${c}, `;
      }, '');
      const totalPrice = Object.values(list).reduce((acc, c) => acc += c, 0);

      textElement.textContent += `You bought ${boughtProducts} for ${totalPrice.toFixed(2)}`;

      ev.target.disabled = true;
      for (let product of products) {
         const addButton = product.querySelector('div[class="product-add"] > button');

         addButton.disabled = true;
      }
   }
}