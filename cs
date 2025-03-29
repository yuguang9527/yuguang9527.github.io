<!-- 
The CSCopilot website contains multiple pages. Here's a file structure:

1. index.html - Main landing page
2. integration.html - Plug in our AI CSM page
3. agent-assistance.html - Agent helping customers page
4. features.html - Feature cards page
5. insights.html - Insights section
6. roadmap.html - Product roadmap page
7. security.html - Security and privacy section
8. about-us.html - Founders' message
9. privacy-policy.html - Privacy policy page
10. terms-of-service.html - Terms of service page
11. css/styles.css - Main stylesheet
12. js/scripts.js - JavaScript functions

Below are the contents of each file:
-->

<!-- INDEX.HTML - MAIN LANDING PAGE -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Scale Customer Success With AI</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <section class="hero">
        <div class="container">
            <div class="content-left">
                <h1>Scale Customer Success With AI</h1>
                <p>CSCopilot is an AI CSM that lives in your app, delivering <span class="highlight">personalized</span> support, onboarding, and walkthroughs to every customer.</p>
                <p>It is an all-knowing teammate, driving customer success at scale without adding headcount, so your team can focus on strategic accounts.</p>
                <a href="#" class="btn">
                    Get Started
                    <span class="btn-icon">→</span>
                </a>
            </div>
            
            <div class="content-right">
                <div class="video-container">
                    <div class="video-header">
                        <div class="video-title">Introducing CSCopilot: Your AI CSM</div>
                        <div class="video-controls">
                            <span class="video-control">□</span>
                            <span class="video-control">↗</span>
                            <span class="video-control">✖</span>
                        </div>
                    </div>
                    
                    <div class="video-content">
                        <div class="replay-btn">
                            <span>↻</span>
                            Watch again
                        </div>
                    </div>
                    
                    <div class="video-footer">
                        <div class="reply-text">Reply to Kristi</div>
                        <div class="emoji-container">
                            <span>😀</span>
                            <span>😊</span>
                            <span>🙂</span>
                            <span>🙌</span>
                            <span>👍</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="features-preview">
        <div class="container">
            <h2>Key Features</h2>
            <div class="features-grid">
                <div class="feature-card">
                    <h3 class="feature-title">Guided onboarding</h3>
                    <p class="feature-description">
                        The agent gives each new user personalized onboarding instructions based on their use case — no manual setup or one-size-fits-all playbooks required.
                    </p>
                </div>
                
                <div class="feature-card">
                    <h3 class="feature-title">In-app support and walkthroughs</h3>
                    <p class="feature-description">
                        It answers support questions in real time, offers contextual walkthroughs, and fills in the gaps even when your documentation doesn't. That means fewer tickets and a better user experience.
                    </p>
                </div>
                
                <div class="feature-card">
                    <h3 class="feature-title">Smart escalation</h3>
                    <p class="feature-description">
                        If the agent doesn't know something, it flags the issue and routes it to your team — so nothing falls through the cracks.
                    </p>
                </div>
            </div>
            <div class="cta-center">
                <a href="features.html" class="btn btn-secondary">See All Features</a>
            </div>
        </div>
    </section>

    <section class="integration-preview">
        <div class="container">
            <h2>Easy Integration</h2>
            <p class="section-intro">Embed our widget directly into your app. Just point it to your existing materials — no need to create anything new.</p>
            <div class="cta-center">
                <a href="integration.html" class="btn btn-secondary">Learn More</a>
            </div>
        </div>
    </section>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- INTEGRATION.HTML - PLUG IN OUR AI CSM PAGE -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Integration</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>
    
    <div class="url-bar-container">
        <div class="url-bar">
            <div class="header-controls">
                <button class="nav-btn">←</button>
                <button class="nav-btn">→</button>
                <button class="nav-btn">↻</button>
            </div>
            
            <div class="url-content">
                <span class="url">trycscopilot.io</span>
            </div>
            
            <div class="actions">
                <button class="action-btn">🔍</button>
                <button class="action-btn">⭐</button>
                <button class="action-btn">👤</button>
                <button class="action-btn">⋮</button>
            </div>
        </div>
    </div>

    <section class="integration-section">
        <div class="container">
            <h1>Plug in our AI CSM and give it the right context</h1>
            
            <div class="integration-content">
                <div class="content-left">
                    <p>Embed our widget directly into your app. Just point it to your existing materials — no need to create anything new. Example sources include:</p>
                    
                    <div class="feature-list">
                        <div class="feature-item">
                            <div class="feature-icon">✓</div>
                            <div class="feature-content">
                                <div class="feature-title">Knowledge base articles</div>
                                <div class="feature-desc">— Your existing help center and documentation</div>
                            </div>
                        </div>
                        
                        <div class="feature-item">
                            <div class="feature-icon">✓</div>
                            <div class="feature-content">
                                <div class="feature-title">Tutorial videos</div>
                                <div class="feature-desc">— Product demos and walkthrough videos</div>
                            </div>
                        </div>
                        
                        <div class="feature-item">
                            <div class="feature-icon">✓</div>
                            <div class="feature-content">
                                <div class="feature-title">Support tickets</div>
                                <div class="feature-desc">— Historical support conversations and resolutions</div>
                            </div>
                        </div>
                        
                        <div class="feature-item">
                            <div class="feature-icon">✓</div>
                            <div class="feature-content">
                                <div class="feature-title">Product guides</div>
                                <div class="feature-desc">— Feature explanations and best practices</div>
                            </div>
                        </div>
                    </div>
                </div>
                
                <div class="content-right">
                    <div class="integration-display">
                        <div class="integration-header">
                            <div class="navigation-controls">
                                < >
                            </div>
                        </div>
                        
                        <div class="integration-grid">
                            <div class="integration-card">
                                <div class="card-icon">📚</div>
                                <div class="card-title">Documentation</div>
                            </div>
                            
                            <div class="integration-card">
                                <div class="card-icon">🎬</div>
                                <div class="card-title">Tutorial Videos</div>
                            </div>
                            
                            <div class="integration-card">
                                <div class="card-icon">💬</div>
                                <div class="card-title">Support Tickets</div>
                            </div>
                            
                            <div class="integration-card">
                                <div class="card-icon">📝</div>
                                <div class="card-title">Product Guides</div>
                            </div>
                        </div>
                        
                        <div class="widget-container">
                            <div class="widget-header">
                                <span class="card-icon">📦</span>
                                <span class="widget-title">CSCopilot Widget</span>
                            </div>
                            <div class="widget-content">
                                <div class="widget-line widget-line-long"></div>
                                <div class="widget-line widget-line-medium"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- AGENT-ASSISTANCE.HTML - AGENT HELPING CUSTOMERS PAGE -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Agent Assistance</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <section class="agent-assistance-section">
        <div class="container">
            <h1>The agent starts helping customers right away</h1>
            
            <div class="app-demo">
                <!-- Browser window controls -->
                <div class="browser-controls">
                    <div class="window-buttons">
                        <span class="window-button red-button"></span>
                        <span class="window-button yellow-button"></span>
                        <span class="window-button green-button"></span>
                    </div>
                    <div class="app-title">TaskFlow Pro</div>
                </div>
                
                <!-- App content -->
                <div class="app-content">
                    <!-- Workflow steps -->
                    <div id="step1" class="workflow-step">
                        <div class="step-number">1</div>
                        <div class="step-title">Create Task</div>
                        <div class="step-content"></div>
                    </div>
                    
                    <div id="step3" class="workflow-step">
                        <div class="step-number">3</div>
                        <div class="step-title">Assign Team</div>
                        <div class="step-content"></div>
                    </div>
                    
                    <!-- Project list -->
                    <div class="project-list">
                        <div class="project-title">Projects</div>
                        <div class="project-item">• Marketing</div>
                        <div class="project-item">• Development</div>
                        <div class="project-item">• Design</div>
                        <div class="project-item">• Sales</div>
                    </div>
                    
                    <!-- Task section -->
                    <div class="task-section">
                        <div class="task-row">
                            <div class="checkbox"></div>
                            <div class="task-bar"></div>
                        </div>
                        <div class="task-text">Weekly team meeting</div>
                        
                        <div class="task-row">
                            <div class="checkbox"></div>
                            <div class="task-bar"></div>
                        </div>
                        <div class="task-text">Send monthly report</div>
                        
                        <div class="task-row">
                            <div class="checkbox"></div>
                            <div class="task-bar"></div>
                        </div>
                        <div class="task-text">Update documentation</div>
                        
                        <div class="task-row">
                            <div class="checkbox"></div>
                            <div class="task-bar"></div>
                        </div>
                        <div class="task-text">Review pull requests</div>
                        
                        <div class="buttons-row">
                            <button class="action-button primary-button">Add Task</button>
                            <button class="action-button secondary-button">Filter</button>
                        </div>
                    </div>
                    
                    <!-- Success message -->
                    <div class="success-message">
                        <span class="success-icon">✓</span>
                        Completed!
                    </div>
                    
                    <!-- Set recurring step -->
                    <div id="step2" class="workflow-step">
                        <div class="step-number">2</div>
                        <div class="step-title">Set Recurring</div>
                        <div class="step-content"></div>
                    </div>
                    
                    <!-- Chat assistant -->
                    <div class="chat-container">
                        <div class="chat-header">
                            <span class="chat-icon">🤖</span>
                            <span class="chat-title">CSCopilot Assistant</span>
                        </div>
                        
                        <div class="user-question">
                            <div class="user-avatar">JD</div>
                            <div class="question-text">How do I set up recurring tasks for my team?</div>
                        </div>
                        
                        <div class="assistant-replies">
                            <div class="assistant-reply">
                                <div class="assistant-reply-icon">📁</div>
                                <div class="reply-title">Recurring tasks are great for team productivity! They help with:</div>
                                <ul class="reply-list">
                                    <li class="reply-list-item">Consistent workflow management</li>
                                    <li class="reply-list-item">Reducing manual task creation</li>
                                    <li class="reply-list-item">Ensuring nothing falls through the cracks</li>
                                </ul>
                                <div class="reply-footer">Setting them up is simple and takes just a minute.</div>
                            </div>
                            
                            <div class="assistant-reply">
                                <div class="assistant-reply-icon">📁</div>
                                <div class="reply-title">Here's how to set up recurring tasks:</div>
                                <ol class="steps-list">
                                    <li class="steps-list-item">Create a new task by clicking the "+" button</li>
                                    <li class="steps-list-item">Enable the "Make recurring" option</li>
                                </ol>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- FEATURES.HTML - FEATURE CARDS PAGE -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Features</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html" class="active">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <section class="features-section">
        <div class="container">
            <h1>Key Features</h1>
            
            <div class="features-grid">
                <div class="feature-card">
                    <h2 class="feature-title">Guided onboarding</h2>
                    <p class="feature-description">
                        The agent gives each new user personalized onboarding instructions based on their use case — no manual setup or one-size-fits-all playbooks required.
                    </p>
                </div>
                
                <div class="feature-card">
                    <h2 class="feature-title">In-app support and walkthroughs</h2>
                    <p class="feature-description">
                        It answers support questions in real time, offers contextual walkthroughs, and fills in the gaps even when your documentation doesn't. That means fewer tickets and a better user experience.
                    </p>
                </div>
                
                <div class="feature-card">
                    <h2 class="feature-title">Smart escalation</h2>
                    <p class="feature-description">
                        If the agent doesn't know something, it flags the issue and routes it to your team — so nothing falls through the cracks.
                    </p>
                </div>
            </div>
            
            <div class="features-extended">
                <div class="feature-extended-item">
                    <div class="feature-icon-large">
                        <span>🚀</span>
                    </div>
                    <h3>Automated Onboarding</h3>
                    <p>Intelligently guides new users through setup based on role and objectives</p>
                </div>
                
                <div class="feature-extended-item">
                    <div class="feature-icon-large">
                        <span>🔍</span>
                    </div>
                    <h3>Instant Answers</h3>
                    <p>Uses your knowledge base to answer questions without wait times</p>
                </div>
                
                <div class="feature-extended-item">
                    <div class="feature-icon-large">
                        <span>📊</span>
                    </div>
                    <h3>Analytics Dashboard</h3>
                    <p>Track user engagement and identify friction points</p>
                </div>
                
                <div class="feature-extended-item">
                    <div class="feature-icon-large">
                        <span>🔄</span>
                    </div>
                    <h3>Continuous Learning</h3>
                    <p>Gets better over time through real customer interactions</p>
                </div>
            </div>
        </div>
    </section>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- INSIGHTS.HTML - INSIGHTS SECTION -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Actionable Insights</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html" class="active">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <section class="insights-section">
        <div class="container">
            <h1>Get insights that actually help</h1>
            
            <div class="insights-container">
                <div class="insights-text">
                    <p class="intro-text">
                        The agent reviews conversations and flags product feedback, bugs, and friction points in your UI — giving you clear signals on what's hurting retention and what to improve next.
                    </p>
                    
                    <div class="insight-category">
                        <h2 class="category-title">Product Feedback</h2>
                        <p class="category-description">
                            Automatically collect and categorize user suggestions and feature requests, so you know exactly what your customers want next.
                        </p>
                    </div>
                    
                    <div class="insight-category">
                        <h2 class="category-title">UX Friction Points</h2>
                        <p class="category-description">
                            Discover where users get stuck or confused in your interface, with specific recommendations for improvement.
                        </p>
                    </div>
                    
                    <div class="insight-category">
                        <h2 class="category-title">Documentation Gaps</h2>
                        <p class="category-description">
                            Automatically identify missing or incomplete documentation based on user questions, and auto-draft new content from successful conversations to continuously improve your knowledge base.
                        </p>
                    </div>
                </div>
                
                <div class="insights-visual">
                    <div class="analytics-icon">
                        <span class="chart-icon">📊</span>
                    </div>
                    
                    <div class="analytics-card">
                        <div class="progress-section">
                            <div class="progress-label">
                                <span class="label-text">Feature Requests</span>
                            </div>
                            <div class="progress-bar">
                                <div class="progress-fill features-fill"></div>
                            </div>
                        </div>
                        
                        <div class="progress-section">
                            <div class="progress-label">
                                <span class="label-text">UI Friction Points</span>
                            </div>
                            <div class="progress-bar">
                                <div class="progress-fill friction-fill"></div>
                            </div>
                        </div>
                        
                        <div class="progress-section">
                            <div class="progress-label">
                                <span class="label-text">Bug Reports</span>
                            </div>
                            <div class="progress-bar">
                                <div class="progress-fill bugs-fill"></div>
                            </div>
                        </div>
                        
                        <div class="insights-total">
                            Total insights collected
                        </div>
                    </div>
                    
                    <div class="feedback-card">
                        <h3 class="feedback-title">Customer Feedback</h3>
                        
                        <div class="feedback-item">
                            <p class="feedback-quote">"I wish there was a way to batch assign tasks to multiple team members at once."</p>
                            <p class="feedback-type">Feature Request</p>
                        </div>
                        
                        <div class="feedback-item">
                            <p class="feedback-quote">"The export button doesn't work when I have more than 100 tasks in a project."</p>
                            <p class="feedback-type bug-type">Bug Report</p>
                        </div>
                        
                        <div class="feedback-item">
                            <p class="feedback-quote">"It took me 20 minutes to figure out how to set up recurring tasks."</p>
                            <p class="feedback-type friction-type">UX Friction</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- ROADMAP.HTML - PRODUCT ROADMAP PAGE -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Product Roadmap</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
<!-- ROADMAP.HTML (CONTINUED) -->
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html" class="active">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <section class="roadmap-section">
        <div class="container">
            <div class="badge-container">
                <span class="roadmap-badge">Product Roadmap</span>
            </div>
            
            <h1>Move from Reactive to Proactive</h1>
            
            <p class="intro-text">
                Our vision is to evolve the AI CSM beyond reactive support into a truly proactive partner. Here's what we're building next on our roadmap:
            </p>
            
            <div class="features-grid">
                <div class="feature-card">
                    <div class="feature-header">
                        <div class="feature-icon churn-icon">⏱️</div>
                        <h2 class="feature-title">Churn Prevention</h2>
                    </div>
                    <p class="feature-description">
                        Monitors usage analytics to identify accounts at risk of churn and proactively reaches out before problems escalate, using predictive indicators to prioritize intervention.
                    </p>
                </div>
                
                <div class="feature-card">
                    <div class="feature-header">
                        <div class="feature-icon expansion-icon">📈</div>
                        <h2 class="feature-title">Expansion Opportunities</h2>
                    </div>
                    <p class="feature-description">
                        Identifies customers ready for upsell or cross-sell opportunities by analyzing usage patterns and feature adoption rates, then flags them for your team to drive revenue growth.
                    </p>
                </div>
                
                <div class="feature-card">
                    <div class="feature-header">
                        <div class="feature-icon usage-icon">📊</div>
                        <h2 class="feature-title">Usage Insights</h2>
                    </div>
                    <p class="feature-description">
                        Analyzes product usage patterns to provide actionable insights on feature adoption and user engagement, highlighting opportunities to improve product stickiness.
                    </p>
                </div>
                
                <div class="feature-card">
                    <div class="feature-header">
                        <div class="feature-icon community-icon">💬</div>
                        <h2 class="feature-title">Community Management</h2>
                    </div>
                    <p class="feature-description">
                        Integrates with your community platforms to monitor discussions, answer questions, and foster engagement by providing timely, accurate responses based on your knowledge base.
                    </p>
                </div>
                
                <div class="feature-card">
                    <div class="feature-header">
                        <div class="feature-icon health-icon">👥</div>
                        <h2 class="feature-title">Customer Health Monitoring</h2>
                    </div>
                    <p class="feature-description">
                        Continuously tracks customer health scores and proactively schedules check-ins with accounts that need attention, using a combination of engagement metrics and sentiment analysis.
                    </p>
                </div>
                
                <div class="coming-soon-card">
                    <div class="plus-circle">+</div>
                    <h2 class="coming-soon-title">More Coming Soon</h2>
                    <p class="coming-soon-text">
                        We're constantly expanding our proactive capabilities to help you drive customer success.
                    </p>
                </div>
            </div>
        </div>
    </section>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- SECURITY.HTML - SECURITY AND PRIVACY SECTION -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Security and Privacy</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html" class="active">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <section class="security-section">
        <div class="container">
            <h1>Security and Privacy You Can Trust</h1>
            
            <p class="intro-text">
                We've embedded security and privacy into CSCopilot from day one.
            </p>
            
            <div class="security-features">
                <div class="security-feature">
                    <div class="icon-container">
                        <div class="security-icon">
                            <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 24 24" fill="none" stroke="#5b6af6" stroke-width="2" stroke-linecap="round" stroke-linejoin="round">
                                <path d="M12 22s8-4 8-10V5l-8-3-8 3v7c0 6 8 10 8 10z"></path>
                            </svg>
                        </div>
                    </div>
                    <h2 class="security-title">Enterprise Security</h2>
                    <p class="security-description">
                        All tools used ensure the highest levels of security compliance, providing enterprise-level protection.
                    </p>
                </div>
                
                <div class="security-feature">
                    <div class="icon-container">
                        <div class="security-icon">
                            <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 24 24" fill="none" stroke="#5b6af6" stroke-width="2" stroke-linecap="round" stroke-linejoin="round">
                                <rect x="3" y="11" width="18" height="11" rx="2" ry="2"></rect>
                                <path d="M7 11V7a5 5 0 0 1 10 0v4"></path>
                            </svg>
                        </div>
                    </div>
                    <h2 class="security-title">Data Encryption</h2>
                    <p class="security-description">
                        Your data is encrypted and protected using industry-leading security standards and best practices.
                    </p>
                </div>
                
                <div class="security-feature">
                    <div class="icon-container">
                        <div class="security-icon">
                            <svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 24 24" fill="none" stroke="#5b6af6" stroke-width="2" stroke-linecap="round" stroke-linejoin="round">
                                <rect x="3" y="3" width="7" height="7"></rect>
                                <rect x="14" y="3" width="7" height="7"></rect>
                                <rect x="14" y="14" width="7" height="7"></rect>
                                <rect x="3" y="14" width="7" height="7"></rect>
                            </svg>
                        </div>
                    </div>
                    <h2 class="security-title">Secure Infrastructure</h2>
                    <p class="security-description">
                        Built on enterprise-grade infrastructure with multiple layers of security and redundancy.
                    </p>
                </div>
            </div>
        </div>
    </section>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- ABOUT-US.HTML - FOUNDERS' MESSAGE -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - About Us</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html" class="active">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <section class="about-section">
        <div class="container">
            <h1>A Message From Us</h1>
            
            <div class="message-card">
                <div class="message-content">
                    <p class="message-paragraph greeting">Hi there –</p>
                    
                    <p class="message-paragraph">
                        We're <a href="#" class="founder-link">Krish</a> and <a href="#" class="founder-link">Keon</a>, founders of <a href="#" class="company-link">Om Labs</a> and the creators of CS Copilot.
                    </p>
                    
                    <p class="message-paragraph">
                        We're a Stanford-originated team, backed by AllianceDAO, Balaji Srinivasan, Soma Capital, Hashed EM, Alchemy Ventures, and others who share our belief in what's coming next.
                    </p>
                    
                    <p class="message-paragraph">
                        Before this, we built 0xPass — the fastest distributed key management system that made it dead simple for developers to spin up crypto wallets. We worked hands-on with early-stage teams, and we personally handled every support request, every bug report, and every feature feedback loop.
                    </p>
                    
                    <p class="message-paragraph">
                        That experience stuck with us.
                    </p>
                    
                    <p class="message-paragraph">
                        When it came time to build again, one question kept coming back:
                        <span class="highlighted-question">What if every company could offer founder-level customer success — at scale?</span>
                    </p>
                    
                    <p class="message-paragraph">
                        CS Copilot is our answer.
                    </p>
                    
                    <p class="message-paragraph">
                        We believe the future of work includes AI employees — not just tools. You'll hire, onboard, and manage digital teammates the same way you do people. And we believe Customer Success is the right place to start.
                    </p>
                    
                    <p class="message-paragraph">
                        Post-sales is the lifeblood of a business. It's where retention happens, where product insights emerge, and where real relationships are built.
                    </p>
                    
                    <p class="message-paragraph">
                        We're building a future where managing a digital workforce is effortless — and where companies scale customer success without compromising quality.
                    </p>
                    
                    <p class="message-paragraph">
                        Come build it with us.
                    </p>
                    
                    <p class="message-signature">
                        — Krish & Keon
                    </p>
                </div>
                
                <div class="divider"></div>
            </div>
        </div>
    </section>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- PRIVACY-POLICY.HTML - PRIVACY POLICY PAGE -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Privacy Policy</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <div class="legal-page">
        <div class="container">
            <a href="index.html" class="back-link">
                <span class="back-icon">←</span> Back to Home
            </a>
            
            <div class="legal-content">
                <h1>CSCopilot Privacy Policy</h1>
                <span class="last-updated">Last Updated: March 2025</span>
                
                <div class="legal-text">
                    <p>At Chennchuu Inc., a Delaware C-Corporation ("Company," "CSCopilot," "we," or "us"), we value your privacy and are committed to protecting your personal information. This Privacy Policy explains how we collect, use, disclose, and safeguard your information.</p>
                </div>
                
                <section class="legal-section">
                    <h2>1. Information We Collect</h2>
                    <p>We collect the following types of information:</p>
                    <ul>
                        <li><strong>Personal Data:</strong> Name, email, phone number, and other identifying information provided when using our Services.</li>
                        <li><strong>Usage Data:</strong> IP address, browser type, pages visited, time spent on our platform, and diagnostic data.</li>
                        <li><strong>Customer Data:</strong> Support logs and interactions processed through our AI-powered services.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>2. How We Use Your Information</h2>
                    <p>We use the collected information to:</p>
                    <ul>
                        <li>Provide, maintain, and improve our Services.</li>
                        <li>Enhance customer support experiences and optimize AI models for real-time processing (not for model training).</li>
                        <li>Comply with legal obligations and enforce our Terms of Service.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>3. Data Protection and Security Measures</h2>
                    <p>We employ industry-standard measures to protect your data, including:</p>
                    <ul>
                        <li><strong>Encryption:</strong> Data is encrypted at rest and in transit.</li>
                        <li><strong>Access Controls:</strong> Strict access policies to prevent unauthorized access.</li>
                        <li><strong>Data Retention:</strong> We retain data only as long as necessary for service delivery or as required by law.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>4. Sharing and Third-Party Services</h2>
                    <p>We do not sell or share your personal data without explicit consent. However, we may share data:</p>
                    <ul>
                        <li>With third-party AI tools strictly for real-time processing (without storage or model training).</li>
                        <li>When required by law or legal processes.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>5. Your Rights and Choices</h2>
                    <p>Depending on your jurisdiction, you have rights regarding your data, including:</p>
                    <ul>
                        <li><strong>Access and Correction:</strong> Request a copy of your data and correct inaccuracies.</li>
                        <li><strong>Data Deletion:</strong> Request deletion of your personal information.</li>
                        <li><strong>Opt-Out:</strong> Manage communication preferences and withdraw consent where applicable.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>6. International Data Transfers</h2>
                    <p>Your data may be processed in jurisdictions with different data protection laws. We implement appropriate safeguards to protect your information.</p>
                </section>
                
                <section class="legal-section">
                    <h2>7. Changes to This Privacy Policy</h2>
                    <p>We may update this Privacy Policy periodically. If we make material changes, we will notify you through our Services or via email.</p>
                </section>
                
                <section class="legal-section">
                    <h2>8. Contact Information</h2>
                    <p>For privacy-related inquiries, please contact us at support@omlabs.xyz</p>
                </section>
            </div>
        </div>
    </div>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- TERMS-OF-SERVICE.HTML - TERMS OF SERVICE PAGE -->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CSCopilot - Terms of Service</title>
    <link rel="stylesheet" href="css/styles.css">
</head>
<body>
    <header class="site-header">
        <div class="container">
            <div class="logo">
                <a href="index.html">CSCopilot</a>
            </div>
            <nav class="main-nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="features.html">Features</a></li>
                    <li><a href="insights.html">Insights</a></li>
                    <li><a href="roadmap.html">Roadmap</a></li>
                    <li><a href="security.html">Security</a></li>
                    <li><a href="about-us.html">About Us</a></li>
                </ul>
            </nav>
            <div class="cta-button">
                <a href="#" class="btn">Get Started</a>
            </div>
        </div>
    </header>

    <div class="legal-page">
        <div class="container">
            <a href="index.html" class="back-link">
                <span class="back-icon">←</span> Back to Home
            </a>
            
            <div class="legal-content">
                <h1>CSCopilot Terms of Service</h1>
                <span class="last-updated">Last Updated: March 2025</span>
                
                <div class="legal-text">
                    <p>Welcome to CSCopilot, an advanced AI-driven technical support solution provided by Chennchuu Inc., a Delaware C-Corporation ("Company," "CSCopilot," "we," or "us"). These Terms of Service ("Terms") govern your use of our website, platform, and related services (collectively, the "Services"). By accessing or using the Services, you agree to comply with and be bound by these Terms. If you do not agree, you may not use our Services.</p>
                </div>
                
                <section class="legal-section">
                    <h2>1. Scope and Changes to These Terms</h2>
                    <p>We reserve the right to update, modify, or discontinue any aspect of the Services at our discretion. We will notify users of material changes by updating the "Last Updated" date above. Your continued use of the Services constitutes acceptance of the revised Terms.</p>
                </section>
                
                <section class="legal-section">
                    <h2>2. Eligibility and Account Responsibilities</h2>
                    <ul>
                        <li>You must be at least 18 years old to use our Services.</li>
                        <li>You agree to provide accurate and complete information when registering for or using our Services.</li>
                        <li>You are responsible for safeguarding your account credentials and for any activities conducted under your account.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>3. Data Ownership and Confidentiality</h2>
                    <ul>
                        <li><strong>Customer Ownership:</strong> Customers retain full ownership of all their data, including support logs, interactions, and outputs generated using our Services.</li>
                        <li><strong>Strict Confidentiality:</strong> All personnel handling customer data are subject to confidentiality obligations.</li>
                        <li><strong>Limited Data Access:</strong> We do not access or use customer data beyond what is necessary to operate and maintain the Services.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>4. Permitted Use and Restrictions</h2>
                    <p>By using our Services, you agree not to:</p>
                    <ul>
                        <li>Engage in unlawful, fraudulent, or unauthorized activities.</li>
                        <li>Submit or process sensitive personal data, such as health or financial information, unless explicitly permitted.</li>
                        <li>Interfere with or disrupt the integrity, security, or performance of our Services.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>5. Security Measures</h2>
                    <ul>
                        <li><strong>Data Encryption:</strong> All data is encrypted at rest using AES-256 and in transit using SSL/TLS protocols.</li>
                        <li><strong>Access Control:</strong> Strict role-based access controls (RBAC) and multi-factor authentication (MFA) are enforced.</li>
                        <li><strong>Data Retention and Deletion:</strong> Customer data is retained only as long as necessary. Customers may request deletion at any time.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>6. Compliance and Legal Obligations</h2>
                    <ul>
                        <li><strong>SOC 2 Compliance (Planned):</strong> Security, availability, confidentiality, and integrity controls.</li>
                        <li><strong>Legal Compliance:</strong> We comply with applicable data protection laws and cooperate with regulatory authorities as required.</li>
                    </ul>
                </section>
                
                <section class="legal-section">
                    <h2>7. Limitation of Liability</h2>
                    <p>CSCopilot is provided on an "as-is" and "as-available" basis. To the fullest extent permitted by law, we disclaim all warranties and shall not be liable for any indirect, incidental, or consequential damages arising from the use of our Services.</p>
                </section>
                
                <section class="legal-section">
                    <h2>8. Dispute Resolution</h2>
                    <p>All disputes arising from or related to these Terms shall be resolved through binding arbitration in accordance with the rules of the American Arbitration Association (AAA). By using our Services, you waive your right to a jury trial or participation in a class-action lawsuit.</p>
                </section>
                
                <section class="legal-section">
                    <h2>9. Contact Information</h2>
                    <p>For any questions regarding these Terms, please contact us at support@omlabs.xyz</p>
                </section>
            </div>
        </div>
    </div>

    <footer class="site-footer">
        <div class="container">
            <div class="footer-content">
                <div class="copyright">
                    © 2025 Om Labs (Chennchuu Inc). All rights reserved.
                </div>
                
                <div class="footer-links">
                    <a href="privacy-policy.html" class="footer-link">Privacy Policy</a>
                    <a href="terms-of-service.html" class="footer-link">Terms of Service</a>
                </div>
            </div>
        </div>
    </footer>

    <script src="js/scripts.js"></script>
</body>
</html>

<!-- CSS/STYLES.CSS - MAIN STYLESHEET -->
@charset "UTF-8";

/* Reset and base styles */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}

body {
    background-color: #f9fafb;
    color: #333;
    line-height: 1.6;
}

.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 2rem;
}

a {
    text-decoration: none;
    color: #5b6af6;
}

ul {
    list-style: none;
}

/* Header and Navigation */
.site-header {
    background-color: white;
    box-shadow: 0 1px 3px rgba(0, 0, 0, 0.05);
    padding: 1rem 0;
    position: sticky;
    top: 0;
    z-index: 100;
}

.site-header .container {
    display: flex;
    justify-content: space-between;
    align-items: center;
}

.logo a {
    font-size: 1.5rem;
    font-weight: 700;
    color: #333;
}

.main-nav ul {
    display: flex;
    gap: 2rem;
}

.main-nav a {
    color: #555;
    font-weight: 500;
    transition: color 0.3s ease;
}

.main-nav a:hover, 
.main-nav a.active {
    color: #5b6af6;
}

/* Buttons */
.btn {
    display: inline-flex;
    align-items: center;
    padding: 0.8rem 1.5rem;
    background-color: #5b6af6;
    color: white;
    text-decoration: none;
    font-weight: 600;
    border-radius: 2rem;
    border: none;
    transition: all 0.3s ease;
    box-shadow: 0 2px 5px rgba(91, 106, 246, 0.3);
}

.btn:hover {
    transform: translateY(-2px);
    box-shadow: 0 4px 8px rgba(91, 106, 246, 0.4);
}

.btn-icon {
    margin-left: 0.5rem;
}

.btn-secondary {
    background-color: white;
    color: #5b6af6;
    border: 1px solid rgba(91, 106, 246, 0.3);
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.05);
}

.btn-secondary:hover {
    background-color: #f5f7ff;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

/* CSS/STYLES.CSS - MAIN STYLESHEET (CONTINUED) */

/* Hero Section */
.hero {
    padding: 4rem 0;
    overflow: hidden;
    position: relative;
}

.hero .container {
    display: flex;
    flex-wrap: wrap;
    align-items: center;
    gap: 2rem;
}

.content-left {
    flex: 1;
    min-width: 300px;
}

.content-right {
    flex: 1;
    display: flex;
    justify-content: center;
    min-width: 300px;
}

h1 {
    font-size: 3.5rem;
    font-weight: 700;
    line-height: 1.2;
    margin-bottom: 1.5rem;
    color: #333;
}

h2 {
    font-size: 2rem;
    font-weight: 700;
    margin-bottom: 1.5rem;
    color: #333;
}

h3 {
    font-size: 1.5rem;
    font-weight: 600;
    margin-bottom: 1rem;
    color: #333;
}

p {
    font-size: 1.1rem;
    line-height: 1.7;
    margin-bottom: 1.5rem;
    color: #555;
}

.highlight {
    font-weight: 600;
}

/* Video container */
.video-container {
    background-color: #333;
    border-radius: 10px;
    overflow: hidden;
    width: 100%;
    max-width: 550px;
    box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
}

.video-header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 0.75rem 1rem;
    background-color: #333;
}

.video-title {
    background-color: #4e9eff;
    color: white;
    padding: 0.4rem 0.8rem;
    border-radius: 4px;
    font-size: 0.9rem;
}

.video-controls {
    display: flex;
    gap: 0.5rem;
}

.video-control {
    color: white;
    font-size: 1.2rem;
}

.video-content {
    height: 300px;
    display: flex;
    align-items: center;
    justify-content: center;
    position: relative;
}

.video-footer {
    padding: 0.75rem 1rem;
    background-color: #333;
    display: flex;
    justify-content: space-between;
    border-top: 1px solid rgba(255, 255, 255, 0.1);
}

.replay-btn {
    background-color: #4e9eff;
    color: white;
    padding: 0.4rem 0.8rem;
    border-radius: 4px;
    font-size: 0.9rem;
    display: flex;
    align-items: center;
    gap: 0.5rem;
}

.emoji-container {
    display: flex;
    gap: 0.5rem;
    color: white;
}

/* Feature Cards */
.features-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 1.5rem;
    margin: 2rem 0;
}

.feature-card {
    background-color: white;
    border-radius: 12px;
    padding: 2rem;
    box-shadow: 0 4px 10px rgba(0, 0, 0, 0.03);
    border: 1px solid #f0f0f0;
    display: flex;
    flex-direction: column;
    transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.feature-card:hover {
    transform: translateY(-5px);
    box-shadow: 0 10px 20px rgba(0, 0, 0, 0.05);
}

.feature-title {
    font-size: 1.5rem;
    font-weight: 600;
    color: #5b6af6;
    margin-bottom: 1.2rem;
}

.feature-description {
    color: #555;
    font-size: 1rem;
    line-height: 1.7;
}

.features-preview, .integration-preview {
    padding: 4rem 0;
    text-align: center;
}

.section-intro {
    max-width: 800px;
    margin: 0 auto 2rem;
    font-size: 1.2rem;
}

.cta-center {
    margin-top: 2rem;
}

.features-extended {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 2rem;
    margin: 3rem 0;
}

.feature-extended-item {
    text-align: center;
}

.feature-icon-large {
    font-size: 2.5rem;
    margin-bottom: 1rem;
}

/* Integration Section */
.url-bar-container {
    display: flex;
    justify-content: center;
    padding: 1rem 0;
    background-color: #f9fafb;
    border-bottom: 1px solid #eaeaea;
}

.url-bar {
    display: flex;
    align-items: center;
    background-color: white;
    border-radius: 8px;
    padding: 0.5rem;
    width: 100%;
    max-width: 800px;
    box-shadow: 0 1px 3px rgba(0, 0, 0, 0.05);
}

.header-controls {
    display: flex;
    align-items: center;
    gap: 0.5rem;
}

.nav-btn {
    background: none;
    border: none;
    color: #888;
    cursor: pointer;
    font-size: 1.2rem;
}

.url-content {
    flex: 1;
    text-align: center;
}

.url {
    font-size: 0.9rem;
    color: #555;
}

.actions {
    display: flex;
    gap: 0.5rem;
}

.action-btn {
    background: none;
    border: none;
    color: #888;
    cursor: pointer;
}

.integration-section {
    padding: 3rem 0;
}

.integration-content {
    display: flex;
    flex-wrap: wrap;
    gap: 3rem;
    margin-top: 3rem;
}

.feature-list {
    margin: 2rem 0;
}

.feature-item {
    display: flex;
    align-items: flex-start;
    margin-bottom: 1.5rem;
    gap: 1rem;
}

.feature-icon {
    width: 24px;
    height: 24px;
    background-color: #eef4ff;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    color: #5b6af6;
    flex-shrink: 0;
}

.feature-content {
    flex: 1;
}

.feature-desc {
    color: #666;
    font-size: 1rem;
    margin-top: 0.25rem;
}

.integration-display {
    background-color: white;
    border-radius: 12px;
    box-shadow: 0 10px 25px rgba(0, 0, 0, 0.05);
    padding: 1.5rem;
    width: 100%;
    max-width: 500px;
}

.integration-header {
    display: flex;
    align-items: center;
    justify-content: center;
    margin-bottom: 2rem;
}

.navigation-controls {
    width: 70px;
    height: 70px;
    background-color: #f0f4ff;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    color: #5b6af6;
    font-size: 1.5rem;
}

.integration-grid {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 1rem;
    margin-bottom: 1.5rem;
}

.integration-card {
    background-color: #fafafa;
    border-radius: 8px;
    padding: 1.5rem;
    display: flex;
    flex-direction: column;
    align-items: center;
    text-align: center;
    transition: all 0.3s ease;
}

.integration-card:hover {
    transform: translateY(-3px);
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.05);
}

.card-icon {
    font-size: 2rem;
    color: #5b6af6;
    margin-bottom: 1rem;
}

.card-title {
    font-weight: 600;
    color: #333;
}

.widget-container {
    background-color: #f5f7ff;
    border-radius: 8px;
    padding: 1.5rem;
    width: 100%;
    margin-top: 1.5rem;
}

.widget-header {
    display: flex;
    align-items: center;
    gap: 0.8rem;
    margin-bottom: 1rem;
}

.widget-title {
    font-weight: 600;
    color: #5b6af6;
}

.widget-content {
    display: flex;
    flex-direction: column;
    gap: 0.5rem;
}

.widget-line {
    height: 8px;
    background-color: #d4e0ff;
    border-radius: 4px;
}

.widget-line-long {
    width: 100%;
}

.widget-line-medium {
    width: 80%;
}

/* Agent Assistance Section */
.agent-assistance-section {
    padding: 4rem 0;
    text-align: center;
}

.app-demo {
    background-color: white;
    border-radius: 12px;
    box-shadow: 0 10px 25px rgba(0, 0, 0, 0.05);
    max-width: 900px;
    margin: 3rem auto 0;
    overflow: hidden;
    border: 1px solid #eaeaea;
}

.browser-controls {
    background-color: #f5f7ff;
    padding: 0.5rem 1rem;
    display: flex;
    align-items: center;
    border-bottom: 1px solid #eaeaea;
}

.window-buttons {
    display: flex;
    gap: 0.5rem;
    margin-right: 1rem;
}

.window-button {
    width: 12px;
    height: 12px;
    border-radius: 50%;
    display: block;
}

.red-button {
    background-color: #ff5f57;
}

.yellow-button {
    background-color: #febc2e;
}

.green-button {
    background-color: #28c840;
}

.app-title {
    color: #333;
    font-size: 0.9rem;
    flex: 1;
    text-align: center;
    font-weight: 500;
}

.app-content {
    position: relative;
    padding: 1.5rem;
    min-height: 500px;
}

.workflow-step {
    position: absolute;
    background-color: #f0f4ff;
    border-radius: 8px;
    padding: 1.2rem;
    width: 180px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.05);
}

.step-number {
    display: inline-flex;
    align-items: center;
    justify-content: center;
    width: 28px;
    height: 28px;
    background-color: #5b6af6;
    color: white;
    border-radius: 50%;
    font-weight: 600;
    margin-bottom: 0.5rem;
}

.step-title {
    font-weight: 600;
    margin-bottom: 0.5rem;
    color: #333;
}

.step-content {
    background-color: rgba(255, 255, 255, 0.7);
    height: 40px;
    border-radius: 4px;
    margin-top: 0.5rem;
}

#step1 {
    top: 240px;
    left: 90px;
}

#step2 {
    bottom: 100px;
    left: 150px;
}

#step3 {
    top: 210px;
    left: 220px;
}

.project-list {
    position: absolute;
    top: 365px;
    left: 160px;
    background-color: white;
    padding: 1rem;
    width: 150px;
    border-radius: 4px;
}

.project-title {
    color: #888;
    font-size: 0.9rem;
    margin-bottom: 0.8rem;
}

.project-item {
    font-size: 0.85rem;
    color: #666;
    margin-bottom: 0.5rem;
    padding-left: 0.5rem;
}

.task-section {
    position: absolute;
    top: 150px;
    right: 120px;
    width: 450px;
}

.task-row {
    display: flex;
    align-items: center;
    margin-bottom: 1rem;
}

.checkbox {
    width: 16px;
    height: 16px;
    border: 1px solid #ddd;
    border-radius: 3px;
    margin-right: 1rem;
}

.task-bar {
    flex: 1;
    height: 16px;
    background-color: #f0f0f0;
    border-radius: 8px;
}

.task-text {
    font-size: 0.9rem;
    color: #888;
    margin-left: 2rem;
}

.buttons-row {
    display: flex;
    gap: 1rem;
    margin-top: 2rem;
}

.action-button {
    padding: 0.5rem 1rem;
    border-radius: 4px;
    font-size: 0.9rem;
    border: none;
}

.primary-button {
    background-color: #5b6af6;
    color: white;
}

.secondary-button {
    background-color: #f0f0f0;
    color: #555;
}

.success-message {
    position: absolute;
    right: 120px;
    top: 280px;
    background-color: #e8f5e9;
    border: 1px solid #c8e6c9;
    color: #2e7d32;
    padding: 0.8rem 1rem;
    border-radius: 8px;
    font-size: 0.9rem;
    display: flex;
    align-items: center;
    gap: 0.5rem;
}

.success-icon {
    color: #2e7d32;
    font-weight: bold;
}

.chat-container {
    position: absolute;
    right: 20px;
    bottom: 20px;
    width: 320px;
    background-color: #f8f9fe;
    border-radius: 12px;
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.1);
    overflow: hidden;
}

.chat-header {
    background-color: #f0f4ff;
    padding: 0.8rem 1rem;
    display: flex;
    align-items: center;
    border-bottom: 1px solid #e0e7ff;
}

.chat-icon {
    color: #5b6af6;
    margin-right: 0.5rem;
    font-size: 1.2rem;
}

.chat-title {
    color: #5b6af6;
    font-weight: 600;
}

.user-question {
    padding: 1rem;
    border-bottom: 1px solid #eaeaea;
    display: flex;
    align-items: flex-start;
    gap: 0.8rem;
}

.user-avatar {
    width: 32px;
    height: 32px;
    background-color: #e0e0e0;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    font-weight: 600;
    font-size: 0.8rem;
    color: #333;
}

.question-text {
    flex: 1;
    font-size: 0.9rem;
}

.assistant-replies {
    padding: 1rem;
}

.assistant-reply {
    background-color: #e8f0fe;
    border-radius: 8px;
    padding: 0.8rem;
    margin-bottom: 0.8rem;
    position: relative;
}

.assistant-reply-icon {
    position: absolute;
    top: -10px;
    right: -8px;
    background-color: #5b6af6;
    color: white;
    width: 24px;
    height: 24px;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 0.8rem;
}

.reply-title {
    color: #5b6af6;
    font-weight: 600;
    margin-bottom: 0.5rem;
}

.reply-text {
    font-size: 0.85rem;
    color: #333;
}

.reply-list {
    margin: 0.5rem 0;
    padding-left: 1.5rem;
}

.reply-list-item {
    font-size: 0.85rem;
    margin-bottom: 0.3rem;
    color: #333;
}

.reply-footer {
    font-size: 0.85rem;
    color: #333;
    margin-top: 0.5rem;
}

.steps-list {
    counter-reset: steps;
    padding-left: 1.5rem;
}

.steps-list-item {
    font-size: 0.85rem;
    color: #333;
    margin-bottom: 0.3rem;
    position: relative;
}

.steps-list-item::before {
    counter-increment: steps;
    content: counter(steps) ".";
    position: absolute;
    left: -1.5rem;
    font-weight: 600;
}

/* Insights Section */
.insights-section {
    padding: 4rem 0;
}

.insights-container {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 4rem;
    align-items: center;
    margin-top: 3rem;
}

.insights-text {
    padding-right: 2rem;
}

.intro-text {
    font-size: 1.1rem;
    line-height: 1.7;
    margin-bottom: 2.5rem;
    color: #444;
}

.insight-category {
    margin-bottom: 2rem;
}

.category-title {
    font-size: 1.5rem;
    font-weight: 600;
    color: #4CAF50;
    margin-bottom: 1rem;
}

.category-description {
    font-size: 1rem;
    line-height: 1.7;
    color: #555;
}

.insights-visual {
    position: relative;
}

.analytics-card {
    background-color: white;
    border-radius: 16px;
    box-shadow: 0 10px 30px rgba(0, 0, 0, 0.05);
    padding: 2rem;
    position: relative;
    z-index: 2;
}

.analytics-icon {
    position: absolute;
    top: -30px;
    right: 50px;
    width: 80px;
    height: 80px;
    background-color: #e8f5e9;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    z-index: 1;
}

.chart-icon {
    font-size: 2.5rem;
    color: #4CAF50;
}

.progress-section {
    margin-bottom: 1.5rem;
}

.progress-label {
    display: flex;
    justify-content: space-between;
    margin-bottom: 0.5rem;
}

.label-text {
    font-weight: 500;
    color: #444;
}

.progress-bar {
    height: 10px;
    background-color: #f0f0f0;
    border-radius: 5px;
    overflow: hidden;
    margin-bottom: 1rem;
}

.progress-fill {
    height: 100%;
    background-color: #4CAF50;
    border-radius: 5px;
}

.features-fill {
    width: 85%;
}

.friction-fill {
    width: 40%;
}

.bugs-fill {
    width: 15%;
}

.insights-total {
    font-weight: 500;
    color: #666;
    margin-top: 1.5rem;
}

.feedback-card {
    background-color: white;
    border-radius: 16px;
    box-shadow: 0 10px 30px rgba(0, 0, 0, 0.05);
    padding: 1.5rem;
    position: absolute;
    top: 50%;
    right: -80px;
    width: 300px;
    z-index: 3;
}

.feedback-title {
    font-weight: 600;
    color: #333;
    margin-bottom: 1rem;
}

.feedback-item {
    margin-bottom: 1.2rem;
}

.feedback-quote {
    font-style: italic;
    color: #555;
    margin-bottom: 0.5rem;
}

.feedback-type {
    color: #4CAF50;
    font-size: 0.9rem;
    font-weight: 500;
}

.bug-type {
    color: #F44336;
}

.friction-type {
    color: #FF9800;
}

/* Roadmap Section */
.roadmap-section {
    padding: 4rem 0;
}

.badge-container {
    text-align: center;
    margin-bottom: 1.5rem;
}

.roadmap-badge {
    background-color: #eff1fe;
    color: #5b6af6;
    font-weight: 600;
    font-size: 0.9rem;
    padding: 0.5rem 1rem;
    border-radius: 100px;
    display: inline-block;
}

.coming-soon-card {
    background-color: #f0f4ff;
    border-radius: 12px;
    padding: 2rem;
    box-shadow: 0 4px 10px rgba(0, 0, 0, 0.03);
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    text-align: center;
    height: 100%;
}

.plus-circle {
    width: 48px;
    height: 48px;
    background-color: #d4e0ff;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 1.5rem;
    color: #5b6af6;
    margin-bottom: 1.5rem;
}

.coming-soon-title {
    font-weight: 600;
    font-size: 1.25rem;
    color: #5b6af6;
    margin-bottom: 1rem;
}

.coming-soon-text {
    color: #5b6af6;
    font-size: 1rem;
    line-height: 1.7;
}

.feature-header {
    display: flex;
    align-items: center;
    margin-bottom: 1.2rem;
    gap: 1rem;
}

.churn-icon {
    background-color: #ffebee;
    color: #f44336;
}

.expansion-icon {
    background-color: #e8f5e9;
    color: #4caf50;
}

.usage-icon {
    background-color: #e3f2fd;
    color: #2196f3;
}

.community-icon {
    background-color: #f3e5f5;
    color: #9c27b0;
}

.health-icon {
    background-color: #fff8e1;
    color: #ffc107;
}

/* Security Section */
.security-section {
    padding: 4rem 0;
}

.security-features {
    display: flex;
    justify-content: space-around;
    flex-wrap: wrap;
    gap: 2rem;
    margin-top: 3rem;
}

.security-feature {
    max-width: 300px;
    text-align: center;
    display: flex;
    flex-direction: column;
    align-items: center;
}

.icon-container {
    width: 100px;
    height: 100px;
    background-color: #f5f7ff;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-bottom: 1.5rem;
}

.security-icon {
    font-size: 2.5rem;
    color: #5b6af6;
}

.security-title {
    font-size: 1.3rem;
    font-weight: 600;
    margin-bottom: 1rem;
    color: #333;
}

.security-description {
    color: #555;
    font-size: 1rem;
    line-height: 1.7;
}

/* About Section */
.about-section {
    padding: 4rem 0;
}

.message-card {
    background-color: white;
    border-radius: 12px;
    padding: 3rem;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.04);
    position: relative;
    max-width: 800px;
    margin: 3rem auto 0;
}

.divider {
    width: 40px;
    height: 4px;
    background-color: #5b6af6;
    margin: 2rem auto;
}

.message-content {
    font-size: 1rem;
    line-height: 1.8;
    color: #444;
}

.message-paragraph {
    margin-bottom: 1.5rem;
}

.greeting {
    font-size: 1.1rem;
    margin-bottom: 1.5rem;
}

.highlighted-question {
    font-weight: 700;
    color: #333;
    display: block;
    margin: 1rem 0;
}

.founder-link, .company-link {
    color: #5b6af6;
    text-decoration: none;
    font-weight: 600;
}

.founder-link:hover, .company-link:hover {
    text-decoration: underline;
}

.message-signature {
    font-style: italic;
    color: #555;
    margin-top: 2rem;
}

/* Legal Pages */
.legal-page {
    padding: 3rem 0;
}

.back-link {
    display: inline-flex;
    align-items: center;
    color: #5b6af6;
    text-decoration: none;
    font-size: 1rem;
    margin-bottom: 2rem;
}

.back-icon {
    margin-right: 0.5rem;
}

.legal-content {
    background-color: white;
    border-radius: 12px;
    padding: 2.5rem;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.04);
}

.last-updated {
    color: #666;
    display: block;
    margin-bottom: 2rem;
    font-size: 0.95rem;
}

.legal-text {
    margin-bottom: 2rem;
}

.legal-section {
    margin-bottom: 2.5rem;
}

.legal-section h2 {
    font-size: 1.5rem;
    margin-bottom: 1rem;
}

.legal-section ul {
    padding-left: 1.5rem;
    margin: 1rem 0;
}

.legal-section li {
    margin-bottom: 0.75rem;
    position: relative;
}

/* Footer */
.site-footer {
    background-color: #f9fafb;
    border-top: 1px solid #eaeaea;
    padding: 2rem 0;
    margin-top: 3rem;
}

.footer-content {
    display: flex;
    justify-content: space-between;
    align-items: center;
    flex-wrap: wrap;
    gap: 1.5rem;
}

.copyright {
    color: #666;
    font-size: 0.9rem;
}

.footer-links {
    display: flex;
    gap: 1.5rem;
}

.footer-link {
    color: #666;
    text-decoration: none;
    font-size: 0.9rem;
    transition: color 0.2s ease;
}

.footer-link:hover {
    color: #5b6af6;
}

/* Responsive design */
@media (max-width: 1100px) {
    .insights-container, .integration-content {
        grid-template-columns: 1fr;
        gap: 2rem;
    }
    
    .insights-text, .content-left {
        padding-right: 0;
    }
    
    .feedback-card {
        position: relative;
        top: 20px;
        right: 0;
        width: 100%;
        margin-top: 1rem;
    }
    
    .analytics-icon {
        right: 30px;
    }
    
    h1 {
        font-size: 2.5rem;
    }
}

/* CSS/STYLES.CSS - MAIN STYLESHEET (FINAL PART) */

@media (max-width: 900px) {
    .hero .container {
        flex-direction: column;
    }
    
    .container {
        padding: 0 1.5rem;
    }
    
    h1 {
        font-size: 2.2rem;
    }
    
    h2 {
        font-size: 1.8rem;
    }
    
    .security-features {
        flex-direction: column;
        align-items: center;
    }
    
    .message-card {
        padding: 2rem;
    }
    
    .app-demo {
        transform: scale(0.8);
        transform-origin: top center;
    }
    
    .legal-content {
        padding: 1.5rem;
    }
}

@media (max-width: 600px) {
    .app-demo {
        transform: scale(0.6);
    }
    
    .footer-content {
        flex-direction: column;
        text-align: center;
    }
    
    .main-nav {
        display: none;
    }
    
    .mobile-menu-toggle {
        display: block;
    }
    
    h1 {
        font-size: 2rem;
    }
}

/* Mobile menu */
.mobile-menu-toggle {
    display: none;
    background: none;
    border: none;
    font-size: 1.5rem;
    color: #333;
    cursor: pointer;
}

.mobile-menu {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: white;
    z-index: 200;
    padding: 2rem;
    transform: translateX(-100%);
    transition: transform 0.3s ease;
}

.mobile-menu.active {
    transform: translateX(0);
}

.mobile-menu-close {
    position: absolute;
    top: 1rem;
    right: 1rem;
    background: none;
    border: none;
    font-size: 1.5rem;
    color: #333;
    cursor: pointer;
}

.mobile-menu ul {
    margin-top: 2rem;
}

.mobile-menu li {
    margin-bottom: 1.5rem;
}

.mobile-menu a {
    font-size: 1.2rem;
    font-weight: 500;
}

/* Animations */
@keyframes fadeIn {
    from { opacity: 0; }
    to { opacity: 1; }
}

@keyframes slideInRight {
    from { transform: translateX(50px); opacity: 0; }
    to { transform: translateX(0); opacity: 1; }
}

@keyframes slideInLeft {
    from { transform: translateX(-50px); opacity: 0; }
    to { transform: translateX(0); opacity: 1; }
}

@keyframes slideInUp {
    from { transform: translateY(50px); opacity: 0; }
    to { transform: translateY(0); opacity: 1; }
}

.animate-fade-in {
    animation: fadeIn 1s ease forwards;
}

.animate-slide-right {
    animation: slideInRight 1s ease forwards;
}

.animate-slide-left {
    animation: slideInLeft 1s ease forwards;
}

.animate-slide-up {
    animation: slideInUp 1s ease forwards;
}

/* Animation delay classes */
.delay-100 { animation-delay: 100ms; }
.delay-200 { animation-delay: 200ms; }
.delay-300 { animation-delay: 300ms; }
.delay-400 { animation-delay: 400ms; }
.delay-500 { animation-delay: 500ms; }

/* Preload (hidden while page loads) */
.preload {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: white;
    display: flex;
    align-items: center;
    justify-content: center;
    z-index: 9999;
    transition: opacity 0.5s ease;
}

.preload.hidden {
    opacity: 0;
    pointer-events: none;
}

.loader {
    width: 50px;
    height: 50px;
    border: 5px solid #f3f3f3;
    border-top: 5px solid #5b6af6;
    border-radius: 50%;
    animation: spin 1s linear infinite;
}

@keyframes spin {
    0% { transform: rotate(0deg); }
    100% { transform: rotate(360deg); }
}

/* JS/SCRIPTS.JS - JAVASCRIPT FUNCTIONS */
document.addEventListener('DOMContentLoaded', function() {
    // Preloader
    const preloader = document.querySelector('.preload');
    if (preloader) {
        window.addEventListener('load', function() {
            preloader.classList.add('hidden');
        });
        
        // Fallback if load event doesn't fire
        setTimeout(function() {
            preloader.classList.add('hidden');
        }, 1000);
    }
    
    // Mobile menu toggle
    const menuToggle = document.querySelector('.mobile-menu-toggle');
    const mobileMenu = document.querySelector('.mobile-menu');
    const closeMenu = document.querySelector('.mobile-menu-close');
    
    if (menuToggle && mobileMenu) {
        menuToggle.addEventListener('click', function() {
            mobileMenu.classList.add('active');
            document.body.style.overflow = 'hidden'; // Prevent scrolling when menu is open
        });
        
        closeMenu.addEventListener('click', function() {
            mobileMenu.classList.remove('active');
            document.body.style.overflow = ''; // Re-enable scrolling
        });
        
        // Close menu when clicking outside
        document.addEventListener('click', function(event) {
            if (mobileMenu.classList.contains('active') && 
                !mobileMenu.contains(event.target) && 
                event.target !== menuToggle) {
                mobileMenu.classList.remove('active');
                document.body.style.overflow = '';
            }
        });
    }
    
    // Smooth scroll for anchor links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function(e) {
            e.preventDefault();
            
            const targetId = this.getAttribute('href');
            if (targetId === '#') return;
            
            const targetElement = document.querySelector(targetId);
            if (targetElement) {
                targetElement.scrollIntoView({
                    behavior: 'smooth',
                    block: 'start'
                });
                
                // Close mobile menu if open
                if (mobileMenu && mobileMenu.classList.contains('active')) {
                    mobileMenu.classList.remove('active');
                    document.body.style.overflow = '';
                }
            }
        });
    });
    
    // Animation on scroll
    const animatedElements = document.querySelectorAll('.animate-fade-in, .animate-slide-right, .animate-slide-left, .animate-slide-up');
    
    if (animatedElements.length > 0) {
        // Initial check for elements in viewport
        checkElementsInViewport();
        
        // Check elements on scroll
        window.addEventListener('scroll', checkElementsInViewport);
        
        function checkElementsInViewport() {
            animatedElements.forEach(element => {
                if (isElementInViewport(element) && !element.classList.contains('animated')) {
                    element.classList.add('animated');
                }
            });
        }
        
        function isElementInViewport(el) {
            const rect = el.getBoundingClientRect();
            return (
                rect.top <= (window.innerHeight || document.documentElement.clientHeight) * 0.9 &&
                rect.bottom >= 0
            );
        }
    }
    
    // Form validation (if forms exist)
    const forms = document.querySelectorAll('form');
    if (forms.length > 0) {
        forms.forEach(form => {
            form.addEventListener('submit', function(e) {
                let valid = true;
                const requiredFields = form.querySelectorAll('[required]');
                
                requiredFields.forEach(field => {
                    if (!field.value.trim()) {
                        valid = false;
                        field.classList.add('error');
                        
                        // Create error message if it doesn't exist
                        if (!field.nextElementSibling || !field.nextElementSibling.classList.contains('error-message')) {
                            const errorMessage = document.createElement('div');
                            errorMessage.classList.add('error-message');
                            errorMessage.textContent = 'This field is required';
                            field.parentNode.insertBefore(errorMessage, field.nextSibling);
                        }
                    } else {
                        field.classList.remove('error');
                        
                        // Remove error message if it exists
                        if (field.nextElementSibling && field.nextElementSibling.classList.contains('error-message')) {
                            field.nextElementSibling.remove();
                        }
                    }
                });
                
                if (!valid) {
                    e.preventDefault();
                }
            });
        });
    }
    
    // Add dynamic behavior to FAQ accordions if they exist
    const faqItems = document.querySelectorAll('.faq-item');
    if (faqItems.length > 0) {
        faqItems.forEach(item => {
            const question = item.querySelector('.faq-question');
            const answer = item.querySelector('.faq-answer');
            
            question.addEventListener('click', () => {
                const isOpen = item.classList.contains('active');
                
                // Close all FAQ items
                faqItems.forEach(faqItem => {
                    faqItem.classList.remove('active');
                    faqItem.querySelector('.faq-answer').style.maxHeight = '0';
                });
                
                // Open clicked item if it wasn't open
                if (!isOpen) {
                    item.classList.add('active');
                    answer.style.maxHeight = answer.scrollHeight + 'px';
                }
            });
        });
    }
});
