let start_game = "default", card_player1, card_player2,
deposit, bet, balance, choice;
let coloda = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];

function func_check_start_game() {
    while(start_game != "y"){
        start_game = prompt(`Введите 'y', если хотите начать игру,иначе 'n'`);
        if (start_game == "y"){
    break;
        }
    }
}

function shuffle(array) {
    array.sort(() => Math.random() - 0.5);
}

function player_cards() {
    shuffle(coloda);
    card_player1 = coloda[0];
    card_player2 = coloda[1];
    score = card_player1 + card_player2;
}

function choice_cards_player() {
    choice = prompt(`Если вы хотите взять карту введите 'y', иначе 'n'`);
    if (choice == 'y') {
        while (choice == 'y') {
            shuffle(coloda);
            card_player3 = coloda[2];
            score += card_player3;
            if (score > 21 && choice == 'y') {                                 //32 строка Здесь должна быть функция проверки на больше чем 21 или нет
                alert(`Вы проиграли набрав ${score}`);
        break;
            }else if (score == 21 && choice == 'y') {
                alert(`Ваша ставка сыграла. Вы получаете +  ${2*bet}`);
                balance += 2*bet;
                alert(`Ваш баланс равен ${balance}`);
        break;
            }
            if (choice == 'n') {
                alert(`Вы набрали ${score} очков и завершили игру`);
        break;
            }
        }
    }else alert(`Вы набрали ${score} очков и завершили игру`);
}




func_check_start_game();
deposit = Number(prompt('Введите депозит'));
balance = deposit;
bet = Number(prompt('Введите сумму ставки'));
if (bet > deposit) {
    while (bet > deposit) {
        alert("Данная ставка превышает ваш баланс");
        bet = prompt('Введите сумму ставки');
        if (bet < deposit) {
    break;
        }
    }
}
alert('Вам выдаются карты');
player_cards();
alert(`У вас ${score} очков`);
choice_cards_player();
