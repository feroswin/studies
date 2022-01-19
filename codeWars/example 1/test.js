function narcissistic(value){
    let array = [];
    let valueOld = value;
    while (value !== 0) {
        let residue = value % 10;
        value = Math.floor(value / 10);
        array.unshift(residue);
    }
    alert(array);
    let sum = 0;
    array.forEach((value) => {
        sum += value**array.length;
    });
    console.log(`${valueOld} ${sum}` )
    return valueOld === sum;
}
narcissistic(1652);