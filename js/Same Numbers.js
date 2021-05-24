function same(numb){
    let numbAsString = numb.toString();
    let isSame = true;
    let sum = 0;
    for (let i = 0; i < numbAsString.length; i++) {
        if (i < numbAsString.length-1) {
            if (numbAsString[i] != numbAsString[i+1]) {
                isSame = false;                
            }
        }        
        sum += Number(numbAsString[i]);
    }
    console.log(isSame);
    console.log(sum);
}

same(1234);