import flask
import routes

app = flask.Flask(__name__)
app.config["DEBUG"] = True

routes.add_routes(app)