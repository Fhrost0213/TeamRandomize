import React, { Component } from 'react';
import Randomizer from './Randomizer'

export class Counter extends Component {
  displayName = Counter.name

  constructor(props) {
    super(props);
      this.state = { currentName: "", names: [] };
      this.getItems();
    }

    handleChange = (event) => {
        this.setState({
            currentName: event.target.value 
        });
    }

    handleSubmit = () => {
        fetch('api/SampleData/Post',
            {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({
                    name: this.state.currentName
                })
            })
            .then(this.getItems)
    }

    getItems = () => {
        fetch('api/SampleData/Get')
            .then(response => response.json())
            .then(data => {
                this.setState({ names: data });
            });
    }

    handleClear = () => {
        fetch('api/SampleData/Clear')
        .then(this.getItems())
    }

  render() {
    return (
      <div>
            <h3>Add your name!</h3>
            <input type="text" onChange={this.handleChange} />
            <button onClick={this.handleSubmit}>Add</button>
            {this.state.names.map(name => <span class="list-group-item list-group-item-action">{name}</span>)}
            <br />
            <h3>Teams</h3>
            <Randomizer />
            <br />
            <br />
            <button onClick={this.handleClear}>Clear all names</button>
      </div>
    );
  }
}
