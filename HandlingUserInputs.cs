using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbotApp
{
    public class HandlingUserInputs
    {
        // Dictionary to store the chatbot's responses.  Made it static.
        public static readonly Dictionary<string, string> responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            // --- Password Safety ---
            {"what makes a strong password?", "A strong password uses a mix of uppercase and lowercase letters, numbers, and symbols and is at least 12 characters long."},
            {"how can i create a strong password?", "Combine uppercase and lowercase letters, numbers, and special symbols. Aim for a length of 12 or more characters."},
            {"what is password strength?", "Password strength refers to how resistant a password is to guessing or cracking attempts."},
            {"is it safe to reuse passwords?", "No, it's not safe. Reusing passwords means if one account is compromised, others are also vulnerable."},
            {"should i use a password manager?", "Yes, a password manager can generate and securely store complex passwords for all your accounts."},
            {"what is two factor authentication?", "Two-factor authentication adds an extra security layer requiring a second verification method besides your password."},
            {"how does biometric authentication work?", "Biometric authentication uses unique biological traits like fingerprints or facial scans to verify your identity."},
            {"what is multi-factor authentication", "Multi-factor authentication (MFA) requires two or more verification factors to gain access to an account."},
            {"what are common password mistakes", "Common mistakes include using easily guessable words, birthdates, or common patterns."},
            {"how to avoid password issues", "Use a password manager, enable multi-factor authentication, and avoid reusing passwords."},

            // --- Phishing ---
            {"what is phishing?", "Phishing is a type of online fraud where attackers try to trick you into revealing personal information via deceptive emails or websites."},
            {"what is a suspicious email?", "A suspicious email often asks for personal information, contains unexpected attachments, or urges immediate action."},
            {"what are the signs of a phishing email?", "Look for suspicious sender addresses, generic greetings, urgent requests, typos, and mismatched links."},
            {"how can i avoid phishing attacks?", "Be cautious of unsolicited emails, don't click suspicious links, and verify sender legitimacy."},
            {"what should i do if i clicked a phishing link?", "Immediately change your passwords and notify the affected service provider."},
            {"what is spear phishing?", "Spear phishing is a targeted phishing attack aimed at a specific individual or organization."},
            {"what is whaling attack", "Whaling attacks target high-profile executives or individuals."},
            {"what is vishing", "Vishing uses phone calls to trick people into divulging private information."},
            {"how to avoid phishing", "Verify sender legitimacy, don't click on suspicious links, and be cautious of unsolicited emails."},

            // --- Safe Browsing ---
            {"what is safe browsing?", "Safe browsing involves practices that minimize security risks while using the internet, like checking for HTTPS."},
            {"how can i ensure website security?", "Look for 'HTTPS' and the padlock icon. Be cautious on unfamiliar sites and avoid untrusted downloads."},
            {"is http secure to use?", "No, HTTP is not secure. Always use websites with 'HTTPS'."},
            {"what does https mean?", "HTTPS indicates a secure connection where communication between your browser and the website is encrypted."},
            {"is it safe to download from unknown sites?", "No, downloading from unknown sites can expose you to malware."},
            {"what about browser extension security?", "Only install extensions from trusted sources and review their permissions carefully."},
            {"what is a zero-day exploit?", "A zero-day exploit targets a software vulnerability that is unknown to the vendor."},
            {"how to check if a website is secure", "Check for HTTPS, a padlock icon, and look at the site's security certificate."},
            {"how to avoid browsing issues", "Use HTTPS, download from trusted sources, and keep your browser and extensions updated."},

            // --- Malware ---
            {"what is malware?", "Malware is software designed to harm your computer systems, including viruses, worms, ransomware, and spyware."},
            {"what is a computer virus?", "A virus is malware that attaches to other programs and spreads when those programs are executed."},
            {"what is ransomware?", "Ransomware encrypts your files and demands payment to restore them. Paying is generally not recommended."},
            {"what is spyware?", "Spyware secretly monitors your computer activity and collects personal data."},
            {"how can i protect against malware?", "Keep your software updated, use antivirus software, and be cautious online."},
            {"what is antivirus software?", "Antivirus software helps detect and remove malware. Keep it updated."},
            {"what is a firewall?", "A firewall controls network traffic to prevent unauthorized access."},
            {"what is a trojan horse?", "A Trojan horse is malware disguised as legitimate software."},
            {"what is adware?", "Adware displays unwanted advertisements on your computer."},
            {"how to avoid malware", "Use antivirus software, keep software updated, and avoid suspicious downloads or links."},

            // --- Social Engineering ---
            {"what is social engineering?", "Social engineering manipulates people into revealing information or performing actions."},
            {"what is pretexting?", "Pretexting involves creating a false scenario to trick someone into giving information."},
            {"what is baiting in social engineering?", "Baiting uses enticing offers or devices to lure victims into malicious traps."},
            {"what is quid pro quo in social engineering?", "Quid pro quo offers a benefit in exchange for sensitive information or actions."},
            {"what is tailgating", "Tailgating is when someone follows an authorized person to gain unauthorized access to a restricted area."},
            {"what is dumpster diving", "Dumpster diving involves searching through discarded trash for sensitive information."},
            {"how to avoid social engineering", "Be skeptical of unsolicited requests, verify identities, and be cautious about sharing information."},

            // --- Data Privacy ---
            {"what is data privacy?", "Data privacy is the right to control how your personal information is used."},
            {"what is a privacy policy?", "A privacy policy explains how a website or service handles your data."},
            {"what is gdpr?", "GDPR is a European law protecting personal data and privacy."},
            {"what is data breach", "A data breach is when sensitive or confidential information is accessed or disclosed without authorization."},
            {"what are cookies", "Cookies are small files stored on your computer that websites use to track your browsing activity."},
            {"how to avoid data privacy issues", "Read privacy policies, be mindful of what information you share, and use privacy-enhancing tools."},

            // --- Network Security ---
            {"what is network security?", "Network security protects your network and data from unauthorized access and threats."},
            {"what is a vpn?", "A VPN creates a secure, encrypted connection for online privacy and security."},
            {"how can i secure my wi-fi?", "Use a strong password (WPA3), and consider hiding your network name."},
            {"what is a dos attack", "A Denial-of-Service (DoS) attack floods a system with traffic to make it unavailable."},
            {"what is a man-in-the-middle attack", "A Man-in-the-Middle (MitM) attack intercepts communication between two parties."},
            {"how to avoid network security issues", "Use strong passwords, enable network encryption, and use a firewall and VPN when appropriate."},

            // --- Incident Response ---
            {"what is incident response?", "Incident response is the process of handling security breaches and minimizing their impact."},
            {"how do i report a security incident?", "Report it to your IT department or relevant authorities immediately."},
            {"what is a security audit", "A security audit is a systematic evaluation of an organization's security measures."},
            {"what is digital forensics", "Digital forensics involves investigating digital devices to recover evidence related to a cybercrime."},
            {"how to avoid incident response", "Have an incident response plan, train employees, and regularly update security measures."},

            // --- General Questions ---
            {"what can i ask you?", "You can ask me specific questions about password safety, phishing, safe browsing, malware, social engineering, data privacy, and network security."},
            {"what is your purpose?", "My purpose is to provide you with information and raise awareness about cybersecurity best practices."},
            {"how are you?", "I'm functioning well, ready to assist you with your cybersecurity questions."}
        };

        // Method to simulate a typing effect. Made it static.
        private static void TypeWriteLine(string message, int delay = 30)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        // Method to handle user input and provide responses.
        public static void HandleUserInput(string userName)
        {
            Console.WriteLine($"Hello, {userName}!");
            Console.Write("Bot: ");
            TypeWriteLine($"How are you doing today {userName}?");

            Console.Write($"{userName}: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string userFeeling = Console.ReadLine()?.Trim();  // Get user's feeling
            Console.ResetColor();

            // Respond to user's feeling
            Console.Write("Bot: ");
            if (string.IsNullOrEmpty(userFeeling))
            {
                TypeWriteLine("I hope you are doing well.  How can I help you with cybersecurity today?");
            }
            else
            {
                TypeWriteLine($"I'm glad to hear that {userName}. How can I help you with cybersecurity today?");
            }
            Console.WriteLine($"You can ask me about topics like 'passwords', 'phishing', 'browsing', 'malware', 'social engineering', 'data privacy', etc.");

            while (true)
            {
                Console.Write($"{userName}: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string input = Console.ReadLine()?.ToLower().Trim();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a question or command.");
                    continue;
                }

                if (input == "exit" || input == "quit")
                {
                    Console.WriteLine("Goodbye! Stay safe online!");
                    break;
                }

                if (responses.TryGetValue(input, out string response))
                {
                    Console.Write("Bot: ");
                    TypeWriteLine(response);
                    continue; // Go to the next iteration of the while loop
                }

                // Check for topic keywords and provide a general response
                if (input.Contains("password"))
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I can answer questions about password safety, such as: ");
                    Console.WriteLine("- What makes a strong password?");
                    Console.WriteLine("- How can I create a strong password?");
                    Console.WriteLine("- Is it safe to reuse passwords?");
                    Console.WriteLine("- What is Multi-Factor Authentication?");
                    Console.WriteLine("- What are common password mistakes?");
                    Console.WriteLine("- How to avoid password issues?");
                }
                else if (input.Contains("phishing"))
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I can answer questions about phishing, such as: ");
                    Console.WriteLine("- What is phishing?");
                    Console.WriteLine("- What are the signs of a phishing email?");
                    Console.WriteLine("- How can I avoid phishing attacks?");
                    Console.WriteLine("- What is spear phishing?");
                    Console.WriteLine("- What is whaling attack?");
                    Console.WriteLine("- What is vishing?");
                    Console.WriteLine("- How to avoid phishing?");
                }
                else if (input.Contains("browsing"))
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I can answer questions about safe browsing, such as: ");
                    Console.WriteLine("- What is safe browsing?");
                    Console.WriteLine("- How can I ensure website security?");
                    Console.WriteLine("- Is HTTP secure to use?");
                    Console.WriteLine("- What does HTTPS mean?");
                    Console.WriteLine("- What is a zero-day exploit?");
                    Console.WriteLine("- How to check if a website is secure?");
                    Console.WriteLine("- How to avoid browsing issues?");
                }
                else if (input.Contains("malware"))
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I can answer questions about malware, such as: ");
                    Console.WriteLine("- What is malware?");
                    Console.WriteLine("- How can I protect against malware?");
                    Console.WriteLine("- What is antivirus software?");
                    Console.WriteLine("- What is a computer virus?");
                    Console.WriteLine("- What is ransomware?");
                    Console.WriteLine("- What is spyware?");
                    Console.WriteLine("- What is a trojan horse?");
                    Console.WriteLine("- What is Adware?");
                    Console.WriteLine("- How to avoid malware?");
                }
                else if (input.Contains("social engineering"))
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I can answer questions about social engineering, such as:");
                    Console.WriteLine("- What is social engineering?");
                    Console.WriteLine("- What is pretexting?");
                    Console.WriteLine("- What is baiting in social engineering?");
                    Console.WriteLine("- What is quid pro quo in social engineering?");
                    Console.WriteLine("- What is tailgating?");
                    Console.WriteLine("- What is dumpster diving?");
                    Console.WriteLine("- How to avoid social engineering?");
                }
                else if (input.Contains("data privacy"))
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I can answer questions about data privacy, such as:");
                    Console.WriteLine("- What is data privacy?");
                    Console.WriteLine("- What is a privacy policy?");
                    Console.WriteLine("- What is GDPR?");
                    Console.WriteLine("- What is a data breach?");
                    Console.WriteLine("- What are cookies?");
                    Console.WriteLine("- How to avoid data privacy issues?");
                }
                else if (input.Contains("network security"))
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I can answer questions about network security, such as:");
                    Console.WriteLine("- What is network security?");
                    Console.WriteLine("-  What is a VPN?");
                    Console.WriteLine("- How can I secure my Wi-Fi?");
                    Console.WriteLine("- What is a DOS attack?");
                    Console.WriteLine("- What is a Man-in-the-Middle attack?");
                    Console.WriteLine("- How to avoid network security issues?");
                }
                else if (input.Contains("incident response"))
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I can answer questions about incident response, such as:");
                    Console.WriteLine("- What is incident response?");
                    Console.WriteLine("- How do I report a security incident?");
                    Console.WriteLine("- What is a security audit?");
                    Console.WriteLine("- What is digital forensics?");
                    Console.WriteLine("- How to avoid incident response?");
                }
                else
                {
                    Console.Write("Bot: ");
                    Console.WriteLine("I didn't quite understand that. Could you please rephrase your question or ask about a different cybersecurity topic?");
                }
            }
        }
    }
}
