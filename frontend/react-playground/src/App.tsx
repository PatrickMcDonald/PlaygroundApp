import { useState, useEffect } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

interface OSVersionInfo {
  osDescription: string
  platform: string
  version: string
  servicePack: string
  processArchitecture: string
}

interface AboutResult {
  environment: string
  application: string
  version: string
  dotnetVersion: string
  processUptime: string
  osVersion: OSVersionInfo
  services: Record<string, any>
}

function App() {
  const [aboutData, setAboutData] = useState<AboutResult | null>(null)
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    fetch('/api/about')
      .then(response => {
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`)
        }
        return response.json()
      })
      .then(data => {
        setAboutData(data)
        setLoading(false)
      })
      .catch(err => {
        setError(err.message)
        setLoading(false)
      })
  }, [])

  if (loading) {
    return <div>Loading...</div>
  }

  if (error) {
    return <div>Error: {error}</div>
  }

  return (
    <>
      <div>
        <a href="https://vite.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      
      {aboutData && (
        <div className="card">
          <h2>About {aboutData.application}</h2>
          <div style={{ textAlign: 'left', maxWidth: '600px', margin: '0 auto' }}>
            <p><strong>Environment:</strong> {aboutData.environment}</p>
            <p><strong>Version:</strong> {aboutData.version}</p>
            <p><strong>.NET Version:</strong> {aboutData.dotnetVersion}</p>
            <p><strong>Process Uptime:</strong> {aboutData.processUptime}</p>
            
            <h3>OS Information</h3>
            <p><strong>OS:</strong> {aboutData.osVersion.osDescription}</p>
            <p><strong>Platform:</strong> {aboutData.osVersion.platform}</p>
            <p><strong>Version:</strong> {aboutData.osVersion.version}</p>
            <p><strong>Architecture:</strong> {aboutData.osVersion.processArchitecture}</p>
            
            {Object.keys(aboutData.services).length > 0 && (
              <>
                <h3>Services</h3>
                <ul>
                  {Object.entries(aboutData.services).map(([key, value]) => (
                    <li key={key}>
                      <strong>{key}:</strong> {JSON.stringify(value)}
                    </li>
                  ))}
                </ul>
              </>
            )}
          </div>
        </div>
      )}

      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App
