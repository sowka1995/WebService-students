var staticApiUrl = "http://localhost:4000/api";

// Funkcja sprawdza czy wartość pola
// jest liczbą (opcjonalnie całkowitą paramater isInteger) oraz 
// czy zawiera się w danym przedziale
// Zwraca "", gdy walidacja przebiegła pomyślnie
// w przeciwnym wypadku zwraca informacje walidacyjną 
function IsNumberInRange(val, startRange, endRange, isInteger) {
	if (IsEmptyOrSpaces(val)) {
		return "To pole jest wymagane";
	}
	
	let value = Number(val);
	
	if (isNaN(value)) {
		return "Podana wartość nie jest liczbą";
	}
	if (isInteger === true && !Number.isInteger(value)) {
		return "Podana liczba nie jest liczbą całkowitą";
	}
	if (value >= startRange && value <= endRange) {
		return "";
	}
	return `Liczba musi być z zakresu <${startRange}, ${endRange}>`;	
}

// Funkcja sprawdza czy podana string
// jest pusty bądż zawiera same spacje
function IsEmptyOrSpaces(str){
    return str === null || str.match(/^ *$/) !== null;
}

// Funkcja sprawdzająca czy pole tekstowe
// nie jest puste
function ValidTextField(fieldName) {
	let value = $("#" + fieldName).val();
	
	if (IsEmptyOrSpaces(value)) {
		return "To pole jest wymagane";
	}
	return "";
}

// Funkcja ustawiająca informacje o błędach walidacji
// danego pola
function SetFieldValidationInfo(fieldName, isValid, validationInfo, errorLabel) {
	if (isValid === true) {
		$('#' + fieldName).removeClass("is-invalid");
		$('#' + fieldName).addClass("is-valid");
		$('#' + errorLabel).text(validationInfo);
	} else {
		$('#' + fieldName).removeClass("is-valid");
		$('#' + fieldName).addClass("is-invalid");
		$('#' + errorLabel).text(validationInfo);
	}
}

// Funkcja zdejmująca atrybut 'disabled'
function EnableElement(elementName) {
	$("#" + elementName).removeAttr("disabled");
}

// Funkcja dodająca atrybut 'disabled'
function DisableElement(elementName) {
	$("#" + elementName).attr("disabled", "disabled");
}

// Funkcja tworząca nowy wiersz tabeli z 
// podanej tablicy paramaterów
function CreateTableRow(elementsArray) {
	let row = "<tr>";
	$.each(elementsArray, function(index, value) {
		row += `<td>${value}</td>`;
	});
	row += "</tr>";
	
	return row;
}

// Prosta obsługa błedów
function HandleError(err) {
	if (err.status === 0) {
		alert("Brak połączenia z serwerem");
	} else {
		alert("Wystąpił błąd");
	}
}
