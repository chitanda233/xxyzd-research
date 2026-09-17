package com.kwad.components.core.webview.jsPublicBridge;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkRequest;
import android.telephony.TelephonyManager;
import android.text.TextUtils;
import android.webkit.JavascriptInterface;
import android.webkit.WebView;
import androidx.core.content.ContextCompat;
import com.baidu.mobads.sdk.internal.an;
import com.kuaishou.weapon.p0.g;
import com.kwad.sdk.core.a.b;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.SystemUtil;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.aq;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.Inet4Address;
import java.net.Inet6Address;
import java.net.InetAddress;
import java.net.NetworkInterface;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.security.SecureRandom;
import java.util.Arrays;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.List;
import java.util.Locale;
import java.util.Map;
import javax.net.ssl.HttpsURLConnection;

/* JADX INFO: loaded from: classes3.dex */
public class KSAdChinaMobileJSBridge {
    private static int aoP = 5000;
    private static final List<String> aoQ = Arrays.asList("46000", "46002", "46007", "46004");
    private static final List<String> aoR = Arrays.asList("46003", "46005", "46011");
    private static final List<String> aoS = Arrays.asList("46001", "46006", "46009");
    private WebView adg;
    private ConnectivityManager aoN;
    private TelephonyManager aoO;
    private Context mContext;

    static /* synthetic */ String[] b(KSAdChinaMobileJSBridge kSAdChinaMobileJSBridge) {
        return yz();
    }

    enum OperatorType {
        CHINA_MOBILE(1),
        CHINA_TELECOM(2),
        CHINA_UNICOM(3),
        NO_PHONE_NUMBER_ACCESS_PERMISSION_UNDER_WIFI(-1),
        DATA_NOT_OPENED(-2),
        FAIL(-3);

        public final int value;

        OperatorType(int i) {
            this.value = i;
        }
    }

    public KSAdChinaMobileJSBridge(WebView webView) {
        this.adg = webView;
        try {
            Context context = ServiceProvider.getContext();
            this.mContext = context;
            this.aoN = (ConnectivityManager) context.getSystemService("connectivity");
            this.aoO = (TelephonyManager) this.mContext.getSystemService("phone");
            c.d("KSAdChinaMobileJSBridge", "init KSAdChinaMobileJSBridge succeed");
        } catch (Exception e) {
            c.printStackTraceOnly(e);
        }
    }

    @JavascriptInterface
    public void ksadGetPhoneNumber(String str) {
        if (!SystemUtil.b(this.mContext, g.b)) {
            s(-1, "无网络权限");
            return;
        }
        try {
            c.d("KSAdChinaMobileJSBridge", "ksadGetPhoneNumber called, data:" + str);
            int type = this.aoN.getActiveNetworkInfo().getType();
            if (type == 0) {
                bt(str);
                return;
            }
            boolean z = true;
            if (type == 1) {
                boolean z2 = 1 != this.aoO.getSimState();
                if (ContextCompat.checkSelfPermission(this.mContext, "android.permission.CHANGE_NETWORK_STATE") != 0) {
                    z = false;
                }
                Boolean boolValueOf = Boolean.valueOf(this.aoO.isDataEnabled());
                if (z2 && z && boolValueOf.booleanValue()) {
                    bt(str);
                    return;
                }
                if (!z2) {
                    s(-1, "sim卡不可用");
                } else if (!z) {
                    s(-1, "无网络切换权限");
                } else {
                    if (boolValueOf.booleanValue()) {
                        return;
                    }
                    s(-1, "移动数据未打开");
                }
            }
        } catch (Exception e) {
            s(-5, e.toString());
        }
    }

    @JavascriptInterface
    public int ksadGetOperJudge() {
        try {
            c.d("KSAdChinaMobileJSBridge", "ksadGetOperJudge called");
            String simOperator = this.aoO.getSimOperator();
            if (aoQ.contains(simOperator)) {
                return OperatorType.CHINA_MOBILE.value;
            }
            if (aoR.contains(simOperator)) {
                return OperatorType.CHINA_TELECOM.value;
            }
            if (aoS.contains(simOperator)) {
                return OperatorType.CHINA_UNICOM.value;
            }
            c.d("KSAdChinaMobileJSBridge", "ksadGetOperJudge operator:" + simOperator + " not in list");
            return OperatorType.FAIL.value;
        } catch (Exception e) {
            c.printStackTraceOnly(e);
            return OperatorType.FAIL.value;
        }
    }

    private void bt(String str) {
        try {
            Map<String, String> jSON2MapString = ac.parseJSON2MapString(str);
            String str2 = jSON2MapString.get("url");
            if (str2.isEmpty()) {
                s(-2, "url参数为空");
                return;
            }
            final URL url = new URL(str2);
            final String strBx = bx(jSON2MapString.get("method"));
            if (strBx.isEmpty()) {
                s(-2, "method参数为空");
                return;
            }
            jSON2MapString.get("operType");
            String str3 = jSON2MapString.get("headers");
            if (str3.isEmpty()) {
                s(-2, "headers参数为空");
                return;
            }
            final Map<String, String> jSON2MapString2 = ac.parseJSON2MapString(str3);
            final String str4 = jSON2MapString.get("params");
            if (str4.isEmpty()) {
                s(-2, "params参数为空");
                return;
            }
            this.aoN.requestNetwork(new NetworkRequest.Builder().addCapability(12).addTransportType(0).build(), new ConnectivityManager.NetworkCallback() { // from class: com.kwad.components.core.webview.jsPublicBridge.KSAdChinaMobileJSBridge.1
                @Override // android.net.ConnectivityManager.NetworkCallback
                public final void onAvailable(final Network network) {
                    new Thread(new Runnable() { // from class: com.kwad.components.core.webview.jsPublicBridge.KSAdChinaMobileJSBridge.1.1
                        @Override // java.lang.Runnable
                        public final void run() {
                            try {
                                if (!KSAdChinaMobileJSBridge.this.aoN.getNetworkCapabilities(network).hasTransport(0)) {
                                    KSAdChinaMobileJSBridge.this.s(-1, "network 移动数据未打开");
                                    return;
                                }
                                HttpsURLConnection httpsURLConnection = (HttpsURLConnection) network.openConnection(url);
                                httpsURLConnection.setConnectTimeout(KSAdChinaMobileJSBridge.aoP);
                                httpsURLConnection.setReadTimeout(KSAdChinaMobileJSBridge.aoP);
                                httpsURLConnection.setRequestMethod(strBx);
                                for (Map.Entry entry : jSON2MapString2.entrySet()) {
                                    httpsURLConnection.setRequestProperty((String) entry.getKey(), (String) entry.getValue());
                                }
                                HashMap map = new HashMap();
                                String[] strArrB = KSAdChinaMobileJSBridge.b(KSAdChinaMobileJSBridge.this);
                                map.put("ipv4List", strArrB[0]);
                                map.put("ipv6List", strArrB[1]);
                                map.put("networkType", String.valueOf(KSAdChinaMobileJSBridge.this.yy()));
                                map.put("packageName", ((f) ServiceProvider.get(f.class)).getAppName());
                                String[] strArrBw = KSAdChinaMobileJSBridge.this.bw(ac.parseMap2JSON(map).toString());
                                if (!strArrBw[0].isEmpty() && !strArrBw[1].isEmpty()) {
                                    httpsURLConnection.setRequestProperty("sdkSecret", strArrBw[0]);
                                    httpsURLConnection.setRequestProperty("sdkData", strArrBw[1]);
                                    if (strBx.equals("POST")) {
                                        httpsURLConnection.setDoOutput(true);
                                        httpsURLConnection.setRequestProperty("Charset", "UTF-8");
                                        httpsURLConnection.setRequestProperty("Content-Type", an.d);
                                        OutputStream outputStream = httpsURLConnection.getOutputStream();
                                        outputStream.write(str4.getBytes());
                                        outputStream.close();
                                    } else {
                                        httpsURLConnection.setDoOutput(false);
                                    }
                                    int responseCode = httpsURLConnection.getResponseCode();
                                    if (responseCode != 200) {
                                        KSAdChinaMobileJSBridge.this.s(responseCode, httpsURLConnection.getErrorStream().toString());
                                        return;
                                    }
                                    BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(httpsURLConnection.getInputStream(), "UTF-8"));
                                    String str5 = "";
                                    while (true) {
                                        String line = bufferedReader.readLine();
                                        if (line != null) {
                                            str5 = str5 + line;
                                        } else {
                                            bufferedReader.close();
                                            KSAdChinaMobileJSBridge.this.bu(str5);
                                            KSAdChinaMobileJSBridge.this.aoN.unregisterNetworkCallback(this);
                                            return;
                                        }
                                    }
                                }
                            } catch (Exception e) {
                                c.printStackTraceOnly(e);
                                KSAdChinaMobileJSBridge.this.s(-5, e.getMessage());
                            }
                        }
                    }).start();
                }
            });
        } catch (Exception e) {
            c.printStackTraceOnly(e);
            s(-5, e.getMessage());
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bu(String str) {
        final String str2 = String.format(Locale.US, "javascript:window.receiveNetworkSwitch({data:\"%s\", netType:%d})", bv(str), Integer.valueOf(yy()));
        this.adg.post(new Runnable() { // from class: com.kwad.components.core.webview.jsPublicBridge.KSAdChinaMobileJSBridge.2
            @Override // java.lang.Runnable
            public final void run() {
                c.d("KSAdChinaMobileJSBridge", "jsSuccessCall: " + str2);
                KSAdChinaMobileJSBridge.this.adg.evaluateJavascript(str2, null);
            }
        });
    }

    private static String bv(String str) {
        if (str == null) {
            return null;
        }
        return str.replace("\"", "\\\"");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void s(int i, String str) {
        final String str2 = String.format(Locale.US, "javascript:window.receiveNetworkSwitch({resultCode: %d, desc: %s})", Integer.valueOf(i), str);
        this.adg.post(new Runnable() { // from class: com.kwad.components.core.webview.jsPublicBridge.KSAdChinaMobileJSBridge.3
            @Override // java.lang.Runnable
            public final void run() {
                c.d("KSAdChinaMobileJSBridge", "jsFailCall: " + str2);
                KSAdChinaMobileJSBridge.this.adg.evaluateJavascript(str2, null);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String[] bw(String str) {
        String[] strArr = new String[2];
        try {
            String strLi = e.Li();
            c.d("KSAdChinaMobileJSBridge", "public key is " + strLi);
            byte[] bArr = new byte[16];
            new SecureRandom().nextBytes(bArr);
            c.d("KSAdChinaMobileJSBridge", "aesKey: " + bArr);
            String str2 = new String(com.kwad.sdk.core.a.c.LY().encode(com.kwad.sdk.core.a.g.e(bArr, strLi)), StandardCharsets.UTF_8);
            c.d("KSAdChinaMobileJSBridge", "sdkScret: ".concat(str2));
            String str3 = new String(com.kwad.sdk.core.a.c.LY().encode(b.d(bArr, str)), StandardCharsets.UTF_8);
            c.d("KSAdChinaMobileJSBridge", "sdkData: ".concat(str3));
            strArr[0] = str2;
            strArr[1] = str3;
        } catch (Exception e) {
            s(-3, e.getMessage());
        }
        return strArr;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public int yy() {
        try {
            if (this.aoN == null) {
                return -1;
            }
            boolean zIsDataEnabled = this.aoO.isDataEnabled();
            boolean zIsWifiConnected = aq.isWifiConnected(this.mContext);
            if (zIsDataEnabled && zIsWifiConnected) {
                return 3;
            }
            if (zIsDataEnabled) {
                return 1;
            }
            return zIsWifiConnected ? 2 : -1;
        } catch (Exception e) {
            c.printStackTraceOnly(e);
            return -1;
        }
    }

    private static String[] yz() {
        String[] strArr = {"", ""};
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        try {
            Enumeration<NetworkInterface> networkInterfaces = NetworkInterface.getNetworkInterfaces();
            while (networkInterfaces.hasMoreElements()) {
                NetworkInterface networkInterfaceNextElement = networkInterfaces.nextElement();
                if (!networkInterfaceNextElement.getName().toLowerCase().contains("wlan")) {
                    Enumeration<InetAddress> inetAddresses = networkInterfaceNextElement.getInetAddresses();
                    while (inetAddresses.hasMoreElements()) {
                        InetAddress inetAddressNextElement = inetAddresses.nextElement();
                        if (!inetAddressNextElement.isLoopbackAddress() && !inetAddressNextElement.isLinkLocalAddress()) {
                            String hostAddress = inetAddressNextElement.getHostAddress();
                            if (!TextUtils.isEmpty(hostAddress)) {
                                if (inetAddressNextElement instanceof Inet6Address) {
                                    sb.append(hostAddress).append(",");
                                } else if (inetAddressNextElement instanceof Inet4Address) {
                                    sb2.append(hostAddress).append(",");
                                }
                            }
                        }
                    }
                }
            }
            if (!TextUtils.isEmpty(sb)) {
                sb = sb.delete(sb.length() - 1, sb.length());
            }
            if (!TextUtils.isEmpty(sb2)) {
                sb2 = sb2.delete(sb2.length() - 1, sb2.length());
            }
            strArr[0] = sb2.toString();
            strArr[1] = sb.toString();
            c.d("KSAdChinaMobileJSBridge", "ipv4List: " + strArr[0]);
            c.d("KSAdChinaMobileJSBridge", "ipv6List: " + strArr[1]);
        } catch (Exception unused) {
        }
        return strArr;
    }

    private static String bx(String str) {
        if (str.equals("post")) {
            return "POST";
        }
        return str.equals("get") ? "GET" : str;
    }
}
