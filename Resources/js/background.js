const OnObjectsBound = new Event('OnObjectsBound');
async function prepareJsObjects() {
	const jsObjects = [
		"BackgroundProvider",
		"Controller"
	];

	for (const i in jsObjects) {
		await CefSharp.BindObjectAsync(jsObjects[i]);
	}

	window.dispatchEvent(OnObjectsBound);
};
$(window).ready(async function() { prepareJsObjects()})
