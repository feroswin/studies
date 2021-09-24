let start_game = "default", card_player1, card_player2,
deposit, bet, balance, choice;
let coloda = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];



function shuffle(array) {
    array.sort(() => Math.random() - 0.5);
}

function player_cards() {
    shuffle(coloda);
    card_player1 = coloda[0];
    card_player2 = coloda[1];
    score = card_player1 + card_player2;
}

function diller_cards() {
    shuffle(coloda);
    card_diller1 = coloda[0];
    card_diller2 = coloda[1];
    score_diller = card_diller1 + card_diller2;
}

function check_cards_diller() {
    if (score_diller < 17) {
        while (score_diller < 17) {
            alert(`Диллер берет карту`);
            shuffle(coloda);
            card_diller3 = coloda[3];
            score_diller += card_diller3;
            if (score_diller > score) {
                alert(`Диллер проиграл набрав ${score_diller}очков. Вы выиграли набрав ${score}очков`);
        break;
            }else if (score_diller == score) {
                alert('Ничья');
            }else {
                alert(`Вы выиграли набрав ${score}очков`);
            }
        }
    }
}


while(start_game != "y"){
    start_game = prompt(`Введите 'y', если хотите начать игру,иначе 'n'`);
    if (start_game == "y"){
break;
    }
}
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
alert(`Вам выпадют карты ${card_player1} ${card_player2}, в сумме у вас ${score} очков`);
alert('Диллеру выдаются карты');
diller_cards();
alert(`Диллеру выпадуют карты ${card_diller1} ?`);
choice = prompt(`Если вы хотите взять карту введите 'y', иначе 'n'`);
if (choice == 'y') {
    while (choice == 'y') {
        shuffle(coloda);
        card_player3 = coloda[2];
        score += card_player3;
        alert(`Вам выпала карта ${card_player3}`);
        alert(`У вас ${score} очков`);
        if (score > 21 && choice == 'y') {
            alert(`Вы проиграли набрав ${score}`);
    break;
        }else if (score > 21 && choice == 'n') {
            alert(`Вы проиграли набрав ${score} очков`);
    break;
        }else {
            choice = prompt(`Если вы хотите взять карту введите 'y', иначе 'n'`);
        }
    }
}else {
    alert(`Вы набрали ${score} очков и завершили игру`);
}
