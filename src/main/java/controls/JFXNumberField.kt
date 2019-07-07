package main.java.controls

import com.jfoenix.controls.JFXTextField

class JFXNumberField : JFXTextField() {
    init {
        textProperty().addListener { _, oldValue, newValue ->
            run {
                if (newValue == "")
                    return@run

                if (newValue.length > 8)
                    text = oldValue

                try {
                    Integer.parseInt(newValue)
                } catch (e: NumberFormatException) {
                    text = oldValue
                }
            }
        }
    }
}
