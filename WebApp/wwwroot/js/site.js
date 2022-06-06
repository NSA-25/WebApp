// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

import React from 'react';
import ReactDOM from 'react-dom/client';

function MyForm() {
    return (
        <form>
            <label>Enter your name:
                <input type="text" />
            </label>
        </form>
    )
}

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<MyForm />);
