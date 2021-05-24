function aggr(array) {
    let sumArray = 0;
    let invSum = 0;
    let concArray = '';
for (let i = 0; i < array.length; i++) {
    sumArray += array[i];
    invSum += 1 / array[i];
    concArray += array[i];
    }
    console.log(sumArray);
    console.log(invSum);
    console.log(concArray);
}
aggr([2, 4, 8, 16]);