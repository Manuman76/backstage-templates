from fastapi import FastAPI

app = FastAPI(title="${{ values.name }}")

@app.get("/")
def read_root():
    return {"message": "Hello from Python FastAPI service: ${{ values.name }}!", "type": "${{ values.componentType }}"}

@app.get("/health")
def health_check():
    return {"status": "healthy"}
