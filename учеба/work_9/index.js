
class Game {
    constructor() {
        this.deck = [2,3,4,5,6,7,8,9,10,11,
                     2,3,4,5,6,7,8,9,10,11,
                     2,3,4,5,6,7,8,9,10,11,
                     2,3,4,5,6,7,8,9,10,11]
        this.playerHand = 0;
        this.dillerHand = 0;
    };

    startGame() {
        this.playerHand = [11, 11];
        this.dillerHand = [this.getRandomCard(this.deck), this.getRandomCard(this.deck)];
        console.log(`У игрока карты ${this.playerHand}`);
        console.log(`У диллера карты ${this.dillerHand[0]},?`);
    }

    getRandomCard(deck) {
        let randomIndex = Math.floor(this.deck.length * Math.random());
        return deck[randomIndex];
    };

    getValue(participant) {
        let sum = 0;
        participant.forEach((i) => {
            sum += i;
        });
        return sum;
    };

    hit(participant) {
        let newCard = this.getRandomCard(this.deck)
        participant.push(newCard);
        return newCard;
    }

    checkWinner(player, diller) {
        if (this.getValue(diller) > 21) {
            console.log(`У диллера перебор (${this.getValue(diller)}), вы выиграли, набрав (${this.getValue(player)})`);
        } else if (this.getValue(diller) > this.getValue(player)) {
            console.log(`Вы проиграли, у диллера больше очков (${this.getValue(diller)}), чем у вас (${this.getValue(player)})`);
        } else if (this.getValue(diller) < this.getValue(player)) {
            console.log(`Вы выиграли, у диллера  меньше очков (${this.getValue(diller)}), чем у вас (${this.getValue(player)})`);
        } else {
            console.log(`Ничья`);
        }
    };

    checkDoubleEleven (playerHand) {
        if (playerHand[0] && playerHand[1] === 11) {
            playerHand[1] = 1;
        } else if (playerHand[1] === 11) {
            playerHand[1] = Number(prompt('Второй картой вам выпал туз, выберете его значение 11 или 1'));
        }
        console.log(`У игрока (${this.getValue(playerHand)})`);
    }
}

window.addEventListener('load', () => {
    document.getElementById('buttonStartGame').addEventListener('click', start);
});

const start = () => {
    const game = new Game();
    game.startGame();
    game.checkDoubleEleven(game.playerHand);
    let gameOver = false;
    let getCard = prompt(`Если хотите взять карту введите 'y', иначе 'n'`);
    while (getCard === 'y' && game.getValue(game.playerHand) < 21) {
        game.hit(game.playerHand);
        game.getValue(game.playerHand);
        if (game.getValue(game.playerHand) > 21) {
            gameOver = true;
            break;
        }
        console.log(`У игрока (${game.getValue(game.playerHand)})`);
        getCard = prompt(`Если хотите взять карту введите 'y', иначе 'n'`);
    }
    if (gameOver === true) {
        console.log(`У вас перебор. Вы набрали (${game.getValue(game.playerHand)})`);
    } else {
        while ((game.getValue(game.dillerHand) < game.getValue(game.playerHand)) && game.getValue(game.dillerHand) < 17) {
            console.log(`Диллер берет карту ${game.hit(game.dillerHand)}`);
        }
        game.checkWinner(game.playerHand, game.dillerHand);
    }
}



