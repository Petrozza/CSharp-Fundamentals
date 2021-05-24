function gsd(num1, num2) {
    let smaller = Math.min(num1, num2);
    let gsd = 1;
    for (let count = 1; count <= smaller; count++) {
        
        if (num1 % count == 0 && num2 % count == 0) {
            gsd = count;
        }
        
    }
    console.log(gsd);
}

gsd(2154, 458)