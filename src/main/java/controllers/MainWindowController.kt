package main.java.controllers

import com.jfoenix.controls.JFXDatePicker
import com.jfoenix.controls.JFXTextField
import com.jfoenix.controls.JFXTimePicker
import javafx.event.ActionEvent
import javafx.fxml.FXML
import javafx.scene.control.Label
import main.java.Runtime
import main.java.controls.JFXNumberField

class MainWindowController {
    @FXML
    lateinit var copyright: Label

    @FXML
    lateinit var version: Label

    @FXML
    lateinit var raceName: JFXTextField

    @FXML
    lateinit var length: JFXNumberField

    @FXML
    lateinit var startDate: JFXDatePicker

    @FXML
    lateinit var startTime: JFXTimePicker

    @FXML
    fun initialize() {
        copyright.text = Runtime.COPYRIGHT
        version.text = Runtime.VERSION
    }

    fun showLargeTimer(actionEvent: ActionEvent) {
        if (!validate())
            return

        TODO()
    }

    fun showSmallTimer(actionEvent: ActionEvent) {
        if (!validate())
            return

        TODO()
    }

    private fun validate(): Boolean {
        // Prevent short circuiting
        return raceName.validate() and
                length.validate() and
                startDate.validate() and
                startTime.validate()
    }
}