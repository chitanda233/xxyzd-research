package cn.com.chinatelecom.account.api.net;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.com.chinatelecom.account.api.manager.SwitchNetManager;
import cn.com.chinatelecom.account.api.utils.DeviceInfoUtil;
import cn.com.chinatelecom.account.api.utils.NetUtil;
import java.io.BufferedOutputStream;
import java.io.DataOutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Map;
import javax.net.ssl.HttpsURLConnection;

/* JADX INFO: loaded from: classes.dex */
public abstract class NetworkRequest implements INet {
    public static final int GET = 0;
    public static final int POST = 1;
    private static final String TAG = "NetworkRequest";
    protected Context context;

    protected boolean isIpConnect(boolean z, String str) {
        return z && str != null;
    }

    protected boolean isOsV5() {
        return true;
    }

    public NetworkRequest(Context context) {
        this.context = context;
    }

    private boolean isMobileNet() {
        return NetUtil.isMobileNet(this.context);
    }

    protected HttpURLConnection createHttpConnection(String str, String str2, int i, RequestConfig requestConfig) throws Throwable {
        HttpURLConnection httpURLConnection;
        URL url = new URL(str);
        if (requestConfig.network != null && isOsV5()) {
            httpURLConnection = (HttpURLConnection) requestConfig.network.openConnection(url);
        } else {
            httpURLConnection = (HttpURLConnection) url.openConnection();
        }
        httpURLConnection.setRequestProperty("accept", "*/*");
        if (i == 0) {
            httpURLConnection.setRequestMethod("GET");
        } else {
            httpURLConnection.setRequestMethod("POST");
            httpURLConnection.setDoOutput(true);
            httpURLConnection.setDoInput(true);
        }
        httpURLConnection.setConnectTimeout(requestConfig.getConnetTimeout());
        httpURLConnection.setReadTimeout(requestConfig.getReadTimeout());
        httpURLConnection.setUseCaches(false);
        if (!isMobileNet() && !isOsV5()) {
            httpURLConnection.setInstanceFollowRedirects(false);
        }
        httpURLConnection.addRequestProperty("Accept-Charset", "UTF-8");
        httpURLConnection.addRequestProperty("reqId", requestConfig.reqId);
        httpURLConnection.addRequestProperty("deviceId", DeviceInfoUtil.getDeviceId(this.context));
        if (!TextUtils.isEmpty(str2)) {
            DataOutputStream dataOutputStream = new DataOutputStream(new BufferedOutputStream(httpURLConnection.getOutputStream()));
            dataOutputStream.write(str2.getBytes("UTF-8"));
            dataOutputStream.flush();
            dataOutputStream.close();
        } else {
            httpURLConnection.connect();
        }
        return httpURLConnection;
    }

    protected boolean isHttps(String str) {
        return str.startsWith("https");
    }

    protected HttpsURLConnection createHttpsConnection(String str, String str2, int i, RequestConfig requestConfig) throws Throwable {
        HttpsURLConnection httpsURLConnection;
        URL url = new URL(str);
        if (requestConfig.network != null && isOsV5()) {
            httpsURLConnection = (HttpsURLConnection) requestConfig.network.openConnection(url);
        } else {
            httpsURLConnection = (HttpsURLConnection) url.openConnection();
        }
        httpsURLConnection.setRequestProperty("accept", "*/*");
        if (i == 0) {
            httpsURLConnection.setRequestMethod("GET");
        } else {
            httpsURLConnection.setRequestMethod("POST");
            httpsURLConnection.setDoOutput(true);
            httpsURLConnection.setDoInput(true);
        }
        httpsURLConnection.setConnectTimeout(requestConfig.getConnetTimeout());
        httpsURLConnection.setReadTimeout(requestConfig.getReadTimeout());
        httpsURLConnection.setUseCaches(false);
        if (!isMobileNet() && !isOsV5()) {
            httpsURLConnection.setInstanceFollowRedirects(false);
        }
        httpsURLConnection.addRequestProperty("Accept-Charset", "UTF-8");
        httpsURLConnection.addRequestProperty("reqId", requestConfig.reqId);
        httpsURLConnection.addRequestProperty("deviceId", DeviceInfoUtil.getDeviceId(this.context));
        if (requestConfig.header != null && !requestConfig.header.isEmpty()) {
            for (Map.Entry<String, String> entry : requestConfig.header.entrySet()) {
                httpsURLConnection.addRequestProperty(entry.getKey(), entry.getValue());
            }
        }
        if (!TextUtils.isEmpty(str2)) {
            DataOutputStream dataOutputStream = new DataOutputStream(new BufferedOutputStream(httpsURLConnection.getOutputStream()));
            dataOutputStream.write(str2.getBytes("UTF-8"));
            dataOutputStream.flush();
            dataOutputStream.close();
        } else {
            httpsURLConnection.connect();
        }
        return httpsURLConnection;
    }

    public static void redirectUrlToRoute(Context context, String str) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        try {
            ConnectivityManager connectivityManager = (ConnectivityManager) context.getSystemService("connectivity");
            if (connectivityManager.getNetworkInfo(5).getState().compareTo(NetworkInfo.State.CONNECTED) == 0) {
                ((Boolean) Class.forName("android.net.ConnectivityManager").getMethod("requestRouteToHost", Integer.TYPE, Integer.TYPE).invoke(connectivityManager, 5, Integer.valueOf(SwitchNetManager.lookupHost(SwitchNetManager.extractAddressFromUrl(str))))).booleanValue();
            }
        } catch (Throwable th) {
            CtAuth.warn(TAG, "http doPost > requestUrlToRoute error", th);
        }
    }
}
