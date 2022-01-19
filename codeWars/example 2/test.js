function findOutlier(integers){
    let count = 0;
    let count2 = 0;
    integers.forEach((i) => {
        if (i % 2 === 0) {
            count++
        }
    })
    integers.forEach((i) => {
        if (i % 2 === 1 || i % 2 === -1) {
            count2++
        }
    })
    if(count > count2) {
        integers.forEach((i) => {
            if (i % 2 === 1 || i % 2 === -1) {
                alert(i);
                return i;
            }
        })
    } else{
        integers.forEach((i) => {
            if(i % 2 === 0) {
                alert(i);
                return i;
            }
        })
    }
}
findOutlier([2,6,7,10,12,14,16])