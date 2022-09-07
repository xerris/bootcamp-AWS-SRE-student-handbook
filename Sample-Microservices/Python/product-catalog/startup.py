import flask
import routes
import logconfig

logconfig.initialize_logging()

app = flask.Flask(__name__)
app.config["DEBUG"] = True

routes.add_routes(app)