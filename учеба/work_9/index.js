
class Game {
    constructor() {
        this.deck = [2,3,4,5,6,7,8,9,10,11,
                     2,3,4,5,6,7,8,9,10,11,
                     2,3,4,5,6,7,8,9,10,11,
                     2,3,4,5,6,7,8,9,10,11]
        this.playerHand = 0;
        this.dillerHand = 0;
    };

    // дает по две карты игроку и диллеру и выводит какие карты выпали
    startGame() {
        this.playerHand = [this.getRandomCard(this.deck), this.getRandomCard(this.deck)];
        this.dillerHand = [this.getRandomCard(this.deck), this.getRandomCard(this.deck)];
        document.getElementById('cardsPlayer').innerHTML = `У игрока карты ${this.playerHand}`;
        document.getElementById('cardsDiller').innerHTML = `У диллера карты ${this.dillerHand[0]},?`;
    }

    //дает рандомную карту из колоды
    getRandomCard(deck) {
        let randomIndex = Math.floor(this.deck.length * Math.random());
        return deck[randomIndex];
    };

    // получает сумму очков участника (игрока или диллера)
    getValue(participant) {
        let sum = 0;
        participant.forEach((i) => {
            sum += i;
        });
        return sum;
    };

    // берет карту из колоды и добавляет участнику игры (игроку или диллеру) одну карту
    hit(participant) {
        let newCard = this.getRandomCard(this.deck)
        participant.push(newCard);
        return newCard;
    }

    //проверка на выигрыш
    checkWinner(player, diller) {
        if (this.getValue(diller) > 21) {
            document.getElementById('winner')
                .innerHTML = `У диллера перебор (${this.getValue(diller)}), вы выиграли, набрав (${this.getValue(player)})`;
        } else if (this.getValue(diller) > this.getValue(player)) {
            document.getElementById('winner')
                .innerHTML = `Вы проиграли, у диллера больше очков (${this.getValue(diller)}), чем у вас (${this.getValue(player)})`;
        } else if (this.getValue(diller) < this.getValue(player)) {
            document.getElementById('winner')
                .innerHTML = `Вы выиграли, у диллера  меньше очков (${this.getValue(diller)}), чем у вас (${this.getValue(player)})`;
        } else {
            document.getElementById('winner')
                .innerHTML = `Ничья`;
        }
    };

    //проверка на два туза (11) (11)
    checkDoubleEleven (playerHand) {
        if (playerHand[0] && playerHand[1] === 11) {
            playerHand[1] = 1;
        } else if (playerHand[1] === 11) {
            playerHand[1] = Number(prompt('Второй картой вам выпал туз, выберете его значение 11 или 1'));
        }
        document.getElementById('valuePlayer').innerHTML = `У игрока (${this.getValue(playerHand)})`;
    }
}


window.addEventListener('load', () => {
    document.getElementById('buttonStartGame').addEventListener('click', start);
});


const start = () => {
    const game = new Game();
    let button = window.document.getElementById('getCard');
    let stopButton = window.document.getElementById('stopGetCard');

    button.removeAttribute('disabled', 'disabled');
    stopButton.removeAttribute('disabled', 'disabled');

    document.getElementById('newCardPlayer').innerHTML = '';                                                    // обновляем карты, которые взял игрок
    document.getElementById('newCardDiller').innerHTML = '';                                                    // обновляем карты которые взял диллер для новой игры
    document.getElementById('winner').innerHTML = '';
    game.startGame();
    game.checkDoubleEleven(game.playerHand);
    let gameOver = false;

    button.addEventListener('click', getCard);

    function getCard() {
        let takenCard = game.hit(game.playerHand);
        document.getElementById('newCardPlayer').innerHTML += `<br> Вы взяли ${takenCard}`;
        console.log(`тест очков ${game.getValue(game.playerHand)}`);
        if (game.getValue(game.playerHand) > 21) {
            gameOver = true;
            button.removeEventListener('click', getCard);
        }
        document.getElementById('valuePlayer').innerHTML = `У игрока (${game.getValue(game.playerHand)})`;
    }


    stopButton.addEventListener('click', stopCard);

    function stopCard() {
        if (gameOver === true) {
            button.removeEventListener('click', getCard);
            stopButton.removeEventListener('click', stopCard);
            document.getElementById('winner').innerHTML = `У вас перебор. Вы набрали (${game.getValue(game.playerHand)})`;
        } else {
            while ((game.getValue(game.dillerHand) < game.getValue(game.playerHand)) && game.getValue(game.dillerHand) < 17) {
                document.getElementById('newCardDiller').innerHTML += `<br>Диллер берет карту ${game.hit(game.dillerHand)}`;
            }
            button.removeEventListener('click', getCard);
            game.checkWinner(game.playerHand, game.dillerHand);
            stopButton.removeEventListener('click', stopCard);
        }
    }
}




