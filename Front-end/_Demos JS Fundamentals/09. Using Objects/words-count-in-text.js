function countWords(text) {
    var words = text.split(' '),
        wordCount = {};

    for (var i in words) {
        var word = words[i];

        if (!wordCount[word]) {
            countWords[word] = 0;
        }
        countWords[word] += 1;
    }

    return wordCount;
}

var text = 'We will rock you';
var words = countWords(text);
for (var word in words) {
    console.log(word + ' -> ' + words[word]);
}