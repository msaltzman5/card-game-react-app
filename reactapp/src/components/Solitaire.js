import React, { Component } from 'react';
import './Solitaire.css'

export class Solitaire extends Component {
    static displayName = Solitaire.name;

    render() {
        return (
            <div>
                <h1>Solitaire</h1>
                <div className='game'>
                    <div className='stock deck'>stock</div>
                    <div className='waste'>
                        <div className='card red' data-value='K ♦'>♦</div>    
                    </div>
                    <div></div>
                    <div className='spade card-slot'>♠</div>
                    <div className='club card-slot'>♣</div>
                    <div className='diamond card-slot'>♦</div>
                    <div className='heart card-slot'>♥</div>
                    <div className='first-cell card-slot'>1</div>
                    <div className='second-cell card-slot'>2</div>
                    <div className='third-cell card-slot'>3</div>
                    <div className='fourth-cell card-slot'>4</div>
                    <div className='fifth-cell card-slot'>5</div>
                    <div className='sixth-cell card-slot'>6</div>
                    <div className='seventh-cell card-slot'>7</div>
                </div>
            </div>
        );
    }
}