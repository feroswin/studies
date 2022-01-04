let deck = [2,3,4,5,6,7,8,9,10,11,
            2,3,4,5,6,7,8,9,10,11,
            2,3,4,5,6,7,8,9,10,11,
            2,3,4,5,6,7,8,9,10,11]

function getRandomCard(deck) {
    let randomIndex = Math.floor(deck.length * Math.random());
    return deck[randomIndex];
}

let playerHand;
let dillerHand;

function startGame() {
    playerHand = [getRandomCard(deck), getRandomCard(deck)];
    dillerHand = [getRandomCard(deck), getRandomCard(deck)];
    console.log(`У игрока карты ${playerHand}`);
    console.log(`У диллера карты ${dillerHand[0]},?`);
}

startGame()


function getValue(participant) {
    let sum = 0;
    participant.forEach((i) => {
        sum += i;
    });
    return sum;
}

function hit(participant) {
    let newCard = getRandomCard(deck)
    participant.push(newCard);
    return newCard;
}
let gameOver = false;
let getCard = prompt(`Если хотите взять карту введите 'y', иначе 'n'`);

while (getCard === 'y' && getValue(playerHand) < 21) {
    hit(playerHand);
    getValue(playerHand);
    if (getValue(playerHand) > 21) {
        gameOver = true;
        break;
    }
    console.log(`У игрока (${getValue(playerHand)})`);
    getCard = prompt(`Если хотите взять карту введите 'y', иначе 'n'`);
}


if (gameOver === true) {
    console.log(`У вас перебор. Вы набрали (${getValue(playerHand)})`);
} else {
    while ((getValue(dillerHand) < getValue(playerHand)) && getValue(dillerHand) < 17 ) {
        console.log(`Диллер берет карту ${hit(dillerHand)}`);
    }
    checkWinner(playerHand,dillerHand);
}


function checkWinner(player, diller){
    if (getValue(diller) > 21) {
        console.log(`У диллера перебор (${getValue(diller)}), вы выиграли, набрав (${getValue(player)})`);
    } else if (getValue(diller) > getValue(player)) {
        console.log(`Вы проиграли, у диллера больше очков (${getValue(diller)}), чем у вас (${getValue(player)})`);
    } else if (getValue(diller) < getValue(player)) {
        console.log(`Вы выиграли, у диллера  меньше очков (${getValue(diller)}), чем у вас (${getValue(player)})`);
    } else {
        console.log(`Ничья`);
    }
}