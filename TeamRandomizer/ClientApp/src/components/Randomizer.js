import React, { Component } from 'react';

export default class Randomizer extends Component {
    displayName = Randomizer.name;

    constructor(props) {
        super(props);
        this.state = { names: [] };
    }
    
    handleClick = () => {
        fetch('api/RandomizeTeams')
            .then(response => response.json())
            .then(data => {
                this.setState({ names: data });
            });
    }

    render() {
        return (
            <div>
                <input type="button" value="Randomize Teams" onClick={this.handleClick} />
                {this.state.names.map((item, i) => (
                    <span class="list-group-item list-group-item-action">{item.player1} and {item.player2}</span>
                    ))}
            </div>
            
            )
    }
}