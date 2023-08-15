from flask import Flask
from flask import render_template
from random import randint

app = Flask(__name__)

@app.route('/')
def say_hello():
    name = 'Bob'
    html = f'''
    <h1> Hi, everyone and {name}!</h1>
    <p> I am server</P>
    '''
    return html

@app.route('/buy')
def say_buy():
    context = {
        'title': 'Buy page',
    }
    return render_template('second.html', **context)

@app.route('/start')
def say_start():
    context = {
        'title': 'Main page',
        'name': 'John',
        'number': randint(1,6),
        'temp_list': ['Ann', 'Bob', 'Cirile', 'Dan']
    }
    return render_template('index.html', **context)

@app.route('/stop')
def say_stop():
    return 'Stop'

@app.route('/<name>')
def say_name(name='noname'):
    return f'Hello, {name}!'

if __name__ == '__main__':
    app.run()