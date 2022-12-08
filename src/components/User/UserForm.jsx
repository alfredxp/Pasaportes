import React, { useState } from "react";
import Container from "@material-ui/core/Container";
import TextField from "@material-ui/core/TextField";
import Button from "@material-ui/core/Button";
import IconButton from "@material-ui/core/IconButton";

import Icon from "@material-ui/core/Icon";
import { v4 as uuidv4 } from "uuid";

import { makeStyles } from "@material-ui/core/styles";

export const UserForm = (props) => {
  const useStyles = makeStyles((theme) => ({
    root: {
      "& .MuiTextField-root": {
        margin: theme.spacing(1),
      },
    },
    button: {
      margin: theme.spacing(1),
    },
  }));
  const classes = useStyles();
  const [inputFields, setInputFields] = useState([
    { id: uuidv4(), firstName: "", lastName: "" },
  ]);

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log("InputFields", inputFields);
  };

  const handleChangeInput = (id, event) => {
    const newInputFields = inputFields.map((i) => {
      if (id === i.id) {
        i[event.target.name] = event.target.value;
      }
      return i;
    });

    setInputFields(newInputFields);
  };

  const handleAddFields = () => {
    setInputFields([
      ...inputFields,
      { id: uuidv4(), firstName: "", lastName: "" },
    ]);
  };

  const handleRemoveFields = (id) => {
    const values = [...inputFields];
    values.splice(
      values.findIndex((value) => value.id === id),
      1
    );
    setInputFields(values);
  };
  return (
    <div id="features" className="text-center">
      <div className="container">
        <div className="col-md-10 col-md-offset-1 section-title">
          <h2>Solicitar</h2>
        </div>

        <Container>
          <form className={classes.root} onSubmit={handleSubmit}>
            {inputFields.map((inputField) => (
              <div key={inputField.id}>
                <TextField
                  name="firstName"
                  label="First Name"
                  variant="outlined"
                  value={inputField.firstName}
                  onChange={(event) => handleChangeInput(inputField.id, event)}
                />

                <TextField
                  name="lastName"
                  label="Last Name"
                  variant="outlined"
                  value={inputField.lastName}
                  onChange={(event) => handleChangeInput(inputField.id, event)}
                />
                <br />
                <TextField
                  name="email"
                  label="E-mail"
                  variant="outlined"
                  value={inputField.Email}
                  onChange={(event) => handleChangeInput(inputField.id, event)}
                />
                <TextField
                  name="Direccion"
                  label="Direccion"
                  variant="outlined"
                  value={inputField.Direccion}
                  onChange={(event) => handleChangeInput(inputField.id, event)}
                />
                <br />
                <TextField
                  name="Pais"
                  label="Pais"
                  variant="outlined"
                  value={inputField.Paiss}
                  onChange={(event) => handleChangeInput(inputField.id, event)}
                />

                <TextField
                  name="Vigencia"
                  label="Vigencia"
                  variant="outlined"
                  value={inputField.Vigencia}
                  onChange={(event) => handleChangeInput(inputField.id, event)}
                />
              </div>
            ))}
            <Button
              className={classes.button}
              variant="contained"
              color="primary"
              type="submit"
              onClick={handleSubmit}
            >
              Enviar
            </Button>
          </form>
        </Container>
      </div>
    </div>
  );
};
