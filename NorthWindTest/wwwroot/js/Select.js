Select = {
    GeneralSelect : function (element, options) {
        for (const [key, value] of Object.entries(options)) {
            var option = {
                value: key,
                text: value
            };
            element.append($('<option>', option));
        }
    }
};
