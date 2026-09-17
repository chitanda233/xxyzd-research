package cn.thinkingdata.analytics;

import android.content.Context;
import android.text.TextUtils;
import cn.thinkingdata.analytics.encrypt.TDSecreteKey;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.utils.TDLog;
import com.alipay.sdk.m.p.d;
import com.byazt.nys.PluginConstants;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.TimeZone;
import java.util.concurrent.locks.ReadWriteLock;
import java.util.concurrent.locks.ReentrantReadWriteLock;
import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLSocketFactory;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDConfig {
    private static final String TAG = "ThinkingAnalytics.TDConfig";
    public static final String VERSION = "3.1.1";
    private static final Map<Context, Map<String, TDConfig>> sInstances = new HashMap();
    private volatile boolean mAllowedDebug;
    private cn.thinkingdata.analytics.f.c mConfigStoragePlugin;
    private String mConfigUrl;
    public final Context mContext;
    private String mDebugUrl;
    private TimeZone mDefaultTimeZone;
    public final cn.thinkingdata.analytics.h.b mDnsServiceManager;
    private boolean mEnableMutiprocess;
    private SSLSocketFactory mSSLSocketFactory;
    private String mServerUrl;
    public final String mToken;
    private volatile String name;
    private final Set<String> mDisabledEvents = new HashSet();
    private final ReadWriteLock mDisabledEventsLock = new ReentrantReadWriteLock();
    private volatile ModeEnum mMode = ModeEnum.NORMAL;
    private int mNetworkType = 255;
    private volatile boolean mTrackOldData = true;
    private TDSecreteKey secreteKey = null;
    boolean mEnableEncrypt = false;
    public boolean mEnableDNS = false;
    public boolean mEnableAutoPush = false;
    public boolean enableAutoCalibrated = false;

    public enum ModeEnum {
        NORMAL,
        DEBUG,
        DEBUG_ONLY
    }

    public final class NetworkType {
        public static final int TYPE_2G = 1;
        public static final int TYPE_3G = 2;
        public static final int TYPE_4G = 4;
        public static final int TYPE_5G = 16;
        public static final int TYPE_ALL = 255;
        public static final int TYPE_WIFI = 8;

        public NetworkType() {
        }
    }

    public enum TDDNSService {
        CLOUD_FLARE,
        CLOUD_ALI,
        CLOUD_GOOGLE
    }

    public enum TDMode {
        NORMAL,
        DEBUG,
        DEBUG_ONLY
    }

    class a implements Runnable {
        a() {
        }

        /* JADX WARN: Code duplicated, block: B:114:0x0264  */
        /* JADX WARN: Code duplicated, block: B:193:0x0363  */
        /* JADX WARN: Code duplicated, block: B:195:0x02eb A[EXC_TOP_SPLITTER, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:197:0x0343 A[EXC_TOP_SPLITTER, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:201:0x027f A[EXC_TOP_SPLITTER, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:209:0x0317 A[EXC_TOP_SPLITTER, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:211:0x0358 A[EXC_TOP_SPLITTER, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:224:0x008a A[EXC_TOP_SPLITTER, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:226:0x00a6 A[EDGE_INSN: B:226:0x00a6->B:37:0x00a6 BREAK  A[LOOP:0: B:216:0x0084->B:227:?], SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:229:? A[RETURN, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:22:0x006f A[Catch: all -> 0x029a, Exception -> 0x02a1, JSONException -> 0x02a9, IOException -> 0x02b0, TRY_LEAVE, TryCatch #24 {IOException -> 0x02b0, JSONException -> 0x02a9, Exception -> 0x02a1, all -> 0x029a, blocks: (B:5:0x0029, B:20:0x005a, B:22:0x006f), top: B:218:0x0029 }] */
        /* JADX WARN: Code duplicated, block: B:230:? A[RETURN, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:231:? A[RETURN, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:232:? A[RETURN, SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:233:? A[SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:41:0x00bf A[Catch: Exception -> 0x0231, JSONException -> 0x0233, IOException -> 0x0235, all -> 0x0354, TRY_LEAVE, TryCatch #7 {JSONException -> 0x0233, blocks: (B:39:0x00b7, B:41:0x00bf, B:80:0x01e8, B:82:0x01fb, B:83:0x0209, B:85:0x021c, B:79:0x01e5, B:86:0x022a), top: B:199:0x00b7 }] */
        /* JADX WARN: Code duplicated, block: B:44:0x00ff A[Catch: JSONException -> 0x01e1, Exception -> 0x0231, IOException -> 0x0235, all -> 0x0354, TryCatch #16 {JSONException -> 0x01e1, blocks: (B:42:0x00e3, B:44:0x00ff, B:46:0x0109, B:48:0x010f, B:50:0x0115, B:52:0x011b, B:54:0x0131, B:56:0x0137, B:58:0x013d, B:59:0x0147, B:61:0x014d, B:63:0x0159, B:64:0x0165, B:66:0x0198, B:72:0x01c0, B:74:0x01cf, B:75:0x01dd), top: B:203:0x00e3 }] */
        /* JADX WARN: Code duplicated, block: B:61:0x014d A[Catch: JSONException -> 0x01e1, Exception -> 0x0231, IOException -> 0x0235, all -> 0x0354, TryCatch #16 {JSONException -> 0x01e1, blocks: (B:42:0x00e3, B:44:0x00ff, B:46:0x0109, B:48:0x010f, B:50:0x0115, B:52:0x011b, B:54:0x0131, B:56:0x0137, B:58:0x013d, B:59:0x0147, B:61:0x014d, B:63:0x0159, B:64:0x0165, B:66:0x0198, B:72:0x01c0, B:74:0x01cf, B:75:0x01dd), top: B:203:0x00e3 }] */
        /* JADX WARN: Code duplicated, block: B:63:0x0159 A[Catch: JSONException -> 0x01e1, Exception -> 0x0231, IOException -> 0x0235, all -> 0x0354, TryCatch #16 {JSONException -> 0x01e1, blocks: (B:42:0x00e3, B:44:0x00ff, B:46:0x0109, B:48:0x010f, B:50:0x0115, B:52:0x011b, B:54:0x0131, B:56:0x0137, B:58:0x013d, B:59:0x0147, B:61:0x014d, B:63:0x0159, B:64:0x0165, B:66:0x0198, B:72:0x01c0, B:74:0x01cf, B:75:0x01dd), top: B:203:0x00e3 }] */
        /* JADX WARN: Code duplicated, block: B:66:0x0198 A[Catch: JSONException -> 0x01e1, Exception -> 0x0231, IOException -> 0x0235, all -> 0x0354, TRY_LEAVE, TryCatch #16 {JSONException -> 0x01e1, blocks: (B:42:0x00e3, B:44:0x00ff, B:46:0x0109, B:48:0x010f, B:50:0x0115, B:52:0x011b, B:54:0x0131, B:56:0x0137, B:58:0x013d, B:59:0x0147, B:61:0x014d, B:63:0x0159, B:64:0x0165, B:66:0x0198, B:72:0x01c0, B:74:0x01cf, B:75:0x01dd), top: B:203:0x00e3 }] */
        /* JADX WARN: Code duplicated, block: B:70:0x01b0 A[Catch: all -> 0x01ce, TRY_LEAVE, TryCatch #26 {all -> 0x01ce, blocks: (B:67:0x01a5, B:68:0x01aa, B:70:0x01b0), top: B:206:0x01a5 }] */
        /* JADX WARN: Code duplicated, block: B:82:0x01fb A[Catch: Exception -> 0x0231, JSONException -> 0x0233, IOException -> 0x0235, all -> 0x0354, TryCatch #7 {JSONException -> 0x0233, blocks: (B:39:0x00b7, B:41:0x00bf, B:80:0x01e8, B:82:0x01fb, B:83:0x0209, B:85:0x021c, B:79:0x01e5, B:86:0x022a), top: B:199:0x00b7 }] */
        /* JADX WARN: Code duplicated, block: B:85:0x021c A[Catch: Exception -> 0x0231, JSONException -> 0x0233, IOException -> 0x0235, all -> 0x0354, TryCatch #7 {JSONException -> 0x0233, blocks: (B:39:0x00b7, B:41:0x00bf, B:80:0x01e8, B:82:0x01fb, B:83:0x0209, B:85:0x021c, B:79:0x01e5, B:86:0x022a), top: B:199:0x00b7 }] */
        @Override // java.lang.Runnable
        public void run() throws Throwable {
            Throwable th;
            InputStream inputStream;
            HttpURLConnection httpURLConnection;
            String str;
            Exception exc;
            JSONException jSONException;
            IOException iOException;
            BufferedReader bufferedReader;
            StringBuffer stringBuffer;
            String line;
            JSONObject jSONObject;
            int iIntValue;
            int i;
            JSONObject jSONObject2;
            JSONArray jSONArray;
            int i2;
            long jOptLong;
            JSONObject jSONObject3;
            String string;
            int i3;
            String string2;
            String string3;
            String str2 = "Getting remote config failed due to: ";
            long jCurrentTimeMillis = System.currentTimeMillis();
            try {
                try {
                    try {
                        try {
                            HttpURLConnection httpURLConnection2 = (HttpURLConnection) new URL(TDConfig.this.mConfigUrl).openConnection();
                            try {
                                SSLSocketFactory sSLSocketFactory = TDConfig.this.getSSLSocketFactory();
                                if (sSLSocketFactory != null) {
                                    try {
                                        if (httpURLConnection2 instanceof HttpsURLConnection) {
                                            ((HttpsURLConnection) httpURLConnection2).setSSLSocketFactory(sSLSocketFactory);
                                        }
                                        httpURLConnection2.setConnectTimeout(15000);
                                        httpURLConnection2.setReadTimeout(20000);
                                        httpURLConnection2.setRequestMethod("GET");
                                        if (200 == httpURLConnection2.getResponseCode()) {
                                            inputStream = httpURLConnection2.getInputStream();
                                            try {
                                                try {
                                                    bufferedReader = new BufferedReader(new InputStreamReader(inputStream));
                                                    stringBuffer = new StringBuffer();
                                                    str = "Getting remote config failed due to: ";
                                                    while (true) {
                                                        try {
                                                            line = bufferedReader.readLine();
                                                            if (line != null) {
                                                                break;
                                                            }
                                                            try {
                                                                stringBuffer.append(line);
                                                            } catch (IOException e) {
                                                                iOException = e;
                                                                httpURLConnection = httpURLConnection2;
                                                            } catch (JSONException e2) {
                                                                jSONException = e2;
                                                                httpURLConnection = httpURLConnection2;
                                                                str2 = str;
                                                                TDLog.d(TDConfig.TAG, str2 + jSONException.getMessage());
                                                                if (inputStream != null) {
                                                                    try {
                                                                        inputStream.close();
                                                                    } catch (IOException e3) {
                                                                        e3.printStackTrace();
                                                                    }
                                                                }
                                                                if (httpURLConnection == null) {
                                                                    return;
                                                                }
                                                                httpURLConnection.disconnect();
                                                            } catch (Exception e4) {
                                                                exc = e4;
                                                                httpURLConnection = httpURLConnection2;
                                                                TDLog.d(TDConfig.TAG, str + exc.getMessage());
                                                                if (inputStream != null) {
                                                                    try {
                                                                        inputStream.close();
                                                                    } catch (IOException e5) {
                                                                        e5.printStackTrace();
                                                                    }
                                                                }
                                                                if (httpURLConnection == null) {
                                                                    return;
                                                                }
                                                                httpURLConnection.disconnect();
                                                            } catch (Throwable th2) {
                                                                th = th2;
                                                                httpURLConnection = httpURLConnection2;
                                                                if (inputStream != null) {
                                                                    try {
                                                                        inputStream.close();
                                                                    } catch (IOException e6) {
                                                                        e6.printStackTrace();
                                                                    }
                                                                }
                                                                if (httpURLConnection != null) {
                                                                    throw th;
                                                                }
                                                                httpURLConnection.disconnect();
                                                                throw th;
                                                            }
                                                        } catch (IOException e7) {
                                                            e = e7;
                                                            httpURLConnection = httpURLConnection2;
                                                        } catch (JSONException e8) {
                                                            e = e8;
                                                            httpURLConnection = httpURLConnection2;
                                                        } catch (Exception e9) {
                                                            e = e9;
                                                            httpURLConnection = httpURLConnection2;
                                                            exc = e;
                                                            TDLog.d(TDConfig.TAG, str + exc.getMessage());
                                                            if (inputStream != null) {
                                                                inputStream.close();
                                                            }
                                                            if (httpURLConnection == null) {
                                                                return;
                                                            }
                                                            httpURLConnection.disconnect();
                                                        }
                                                        iOException = e;
                                                        str2 = str;
                                                        TDLog.d(TDConfig.TAG, str2 + iOException.getMessage());
                                                        if (inputStream != null) {
                                                            try {
                                                                inputStream.close();
                                                            } catch (IOException e10) {
                                                                e10.printStackTrace();
                                                            }
                                                        }
                                                        if (httpURLConnection == null) {
                                                            return;
                                                        }
                                                    }
                                                    jSONObject = new JSONObject(stringBuffer.toString());
                                                    httpURLConnection = httpURLConnection2;
                                                    try {
                                                        try {
                                                            if (jSONObject.getString(PluginConstants.KEY_ERROR_CODE).equals("0")) {
                                                                int iIntValue2 = ((Integer) TDConfig.this.mConfigStoragePlugin.get(2)).intValue();
                                                                iIntValue = ((Integer) TDConfig.this.mConfigStoragePlugin.get(1)).intValue();
                                                                try {
                                                                    jSONObject2 = jSONObject.getJSONObject("data");
                                                                    int i4 = jSONObject2.getInt("sync_interval") * 1000;
                                                                    iIntValue = jSONObject2.getInt("sync_batch_size");
                                                                    if (jSONObject2.has("secret_key")) {
                                                                        jSONObject3 = jSONObject2.getJSONObject("secret_key");
                                                                        if (jSONObject3.has("key") && jSONObject3.has("version") && jSONObject3.has("symmetric") && jSONObject3.has("asymmetric")) {
                                                                            string = jSONObject3.getString("key");
                                                                            i3 = jSONObject3.getInt("version");
                                                                            string2 = jSONObject3.getString("symmetric");
                                                                            string3 = jSONObject3.getString("asymmetric");
                                                                            if (!TextUtils.isEmpty(string) && !TextUtils.isEmpty(string2) && !TextUtils.isEmpty(string3)) {
                                                                                TDConfig.this.secreteKey = new TDSecreteKey(string, i3, string2, string3);
                                                                            }
                                                                        }
                                                                    }
                                                                    if (TDConfig.this.enableAutoCalibrated) {
                                                                        jOptLong = jSONObject2.optLong("server_timestamp");
                                                                        if (jOptLong != 0) {
                                                                            cn.thinkingdata.analytics.h.a.a(jOptLong + ((System.currentTimeMillis() - jCurrentTimeMillis) / 2));
                                                                        }
                                                                    }
                                                                    TDLog.i(TDConfig.TAG, "[ThinkingData] Info: Get remote config success (" + q.a(TDConfig.this.mToken, 4) + "):\n" + jSONObject2.toString(4));
                                                                    if (jSONObject2.has("disable_event_list")) {
                                                                        TDConfig.this.mDisabledEventsLock.writeLock().lock();
                                                                        try {
                                                                            jSONArray = jSONObject2.getJSONArray("disable_event_list");
                                                                            for (i2 = 0; i2 < jSONArray.length(); i2++) {
                                                                                TDConfig.this.mDisabledEvents.add(jSONArray.getString(i2));
                                                                            }
                                                                            TDConfig.this.mDisabledEventsLock.writeLock().unlock();
                                                                        } catch (Throwable th3) {
                                                                            TDConfig.this.mDisabledEventsLock.writeLock().unlock();
                                                                            throw th3;
                                                                        }
                                                                    }
                                                                    i = i4;
                                                                } catch (JSONException e11) {
                                                                    i = iIntValue2;
                                                                    e11.printStackTrace();
                                                                }
                                                                if (((Integer) TDConfig.this.mConfigStoragePlugin.get(1)).intValue() != iIntValue) {
                                                                    TDConfig.this.mConfigStoragePlugin.save(1, Integer.valueOf(iIntValue));
                                                                }
                                                                if (((Integer) TDConfig.this.mConfigStoragePlugin.get(2)).intValue() != i) {
                                                                    TDConfig.this.mConfigStoragePlugin.save(2, Integer.valueOf(i));
                                                                }
                                                            }
                                                            inputStream.close();
                                                            bufferedReader.close();
                                                        } catch (JSONException e12) {
                                                            e = e12;
                                                            jSONException = e;
                                                            str2 = str;
                                                            TDLog.d(TDConfig.TAG, str2 + jSONException.getMessage());
                                                            if (inputStream != null) {
                                                                inputStream.close();
                                                            }
                                                            if (httpURLConnection == null) {
                                                                return;
                                                            }
                                                        }
                                                    } catch (IOException e13) {
                                                        e = e13;
                                                        iOException = e;
                                                        str2 = str;
                                                        TDLog.d(TDConfig.TAG, str2 + iOException.getMessage());
                                                        if (inputStream != null) {
                                                            inputStream.close();
                                                        }
                                                        if (httpURLConnection == null) {
                                                            return;
                                                        }
                                                    } catch (Exception e14) {
                                                        e = e14;
                                                        exc = e;
                                                        TDLog.d(TDConfig.TAG, str + exc.getMessage());
                                                        if (inputStream != null) {
                                                            inputStream.close();
                                                        }
                                                        if (httpURLConnection == null) {
                                                            return;
                                                        }
                                                    }
                                                } catch (Throwable th4) {
                                                    th = th4;
                                                    httpURLConnection = httpURLConnection2;
                                                    th = th;
                                                    if (inputStream != null) {
                                                        inputStream.close();
                                                    }
                                                    if (httpURLConnection != null) {
                                                        throw th;
                                                    }
                                                    httpURLConnection.disconnect();
                                                    throw th;
                                                }
                                            } catch (IOException e15) {
                                                httpURLConnection = httpURLConnection2;
                                                iOException = e15;
                                                str2 = "Getting remote config failed due to: ";
                                            } catch (JSONException e16) {
                                                httpURLConnection = httpURLConnection2;
                                                jSONException = e16;
                                                str2 = "Getting remote config failed due to: ";
                                            } catch (Exception e17) {
                                                e = e17;
                                                str = "Getting remote config failed due to: ";
                                            }
                                        } else {
                                            str = "Getting remote config failed due to: ";
                                            httpURLConnection = httpURLConnection2;
                                            try {
                                                TDLog.d(TDConfig.TAG, "Getting remote config failed, responseCode is " + httpURLConnection.getResponseCode());
                                                inputStream = null;
                                            } catch (IOException e18) {
                                                iOException = e18;
                                                str2 = str;
                                                inputStream = null;
                                                TDLog.d(TDConfig.TAG, str2 + iOException.getMessage());
                                                if (inputStream != null) {
                                                    inputStream.close();
                                                }
                                                if (httpURLConnection == null) {
                                                    return;
                                                }
                                            } catch (JSONException e19) {
                                                jSONException = e19;
                                                str2 = str;
                                                inputStream = null;
                                                TDLog.d(TDConfig.TAG, str2 + jSONException.getMessage());
                                                if (inputStream != null) {
                                                    inputStream.close();
                                                }
                                                if (httpURLConnection == null) {
                                                    return;
                                                }
                                            } catch (Exception e20) {
                                                e = e20;
                                                exc = e;
                                                inputStream = null;
                                                TDLog.d(TDConfig.TAG, str + exc.getMessage());
                                                if (inputStream != null) {
                                                    inputStream.close();
                                                }
                                                if (httpURLConnection == null) {
                                                    return;
                                                }
                                            } catch (Throwable th5) {
                                                th = th5;
                                                th = th;
                                                inputStream = null;
                                                if (inputStream != null) {
                                                    inputStream.close();
                                                }
                                                if (httpURLConnection != null) {
                                                    throw th;
                                                }
                                                httpURLConnection.disconnect();
                                                throw th;
                                            }
                                        }
                                        if (inputStream != null) {
                                            try {
                                                inputStream.close();
                                            } catch (IOException e21) {
                                                e21.printStackTrace();
                                            }
                                        }
                                        if (httpURLConnection == null) {
                                            return;
                                        }
                                    } catch (IOException e22) {
                                        iOException = e22;
                                        str2 = "Getting remote config failed due to: ";
                                        httpURLConnection = httpURLConnection2;
                                        inputStream = null;
                                        TDLog.d(TDConfig.TAG, str2 + iOException.getMessage());
                                        if (inputStream != null) {
                                            inputStream.close();
                                        }
                                        if (httpURLConnection == null) {
                                            return;
                                        }
                                        httpURLConnection.disconnect();
                                    } catch (JSONException e23) {
                                        jSONException = e23;
                                        str2 = "Getting remote config failed due to: ";
                                        httpURLConnection = httpURLConnection2;
                                        inputStream = null;
                                        TDLog.d(TDConfig.TAG, str2 + jSONException.getMessage());
                                        if (inputStream != null) {
                                            inputStream.close();
                                        }
                                        if (httpURLConnection == null) {
                                            return;
                                        }
                                        httpURLConnection.disconnect();
                                    } catch (Exception e24) {
                                        exc = e24;
                                        str = "Getting remote config failed due to: ";
                                        httpURLConnection = httpURLConnection2;
                                        inputStream = null;
                                        TDLog.d(TDConfig.TAG, str + exc.getMessage());
                                        if (inputStream != null) {
                                            inputStream.close();
                                        }
                                        if (httpURLConnection == null) {
                                            return;
                                        }
                                        httpURLConnection.disconnect();
                                    } catch (Throwable th6) {
                                        th = th6;
                                        httpURLConnection = httpURLConnection2;
                                        inputStream = null;
                                        if (inputStream != null) {
                                            inputStream.close();
                                        }
                                        if (httpURLConnection != null) {
                                            throw th;
                                        }
                                        httpURLConnection.disconnect();
                                        throw th;
                                    }
                                } else {
                                    httpURLConnection2.setConnectTimeout(15000);
                                    httpURLConnection2.setReadTimeout(20000);
                                    httpURLConnection2.setRequestMethod("GET");
                                    if (200 == httpURLConnection2.getResponseCode()) {
                                        inputStream = httpURLConnection2.getInputStream();
                                        bufferedReader = new BufferedReader(new InputStreamReader(inputStream));
                                        stringBuffer = new StringBuffer();
                                        str = "Getting remote config failed due to: ";
                                        while (true) {
                                            line = bufferedReader.readLine();
                                            if (line != null) {
                                                break;
                                                break;
                                            }
                                            stringBuffer.append(line);
                                            iOException = e;
                                            str2 = str;
                                            TDLog.d(TDConfig.TAG, str2 + iOException.getMessage());
                                            if (inputStream != null) {
                                                inputStream.close();
                                            }
                                            if (httpURLConnection == null) {
                                                return;
                                            }
                                        }
                                        jSONObject = new JSONObject(stringBuffer.toString());
                                        httpURLConnection = httpURLConnection2;
                                        if (jSONObject.getString(PluginConstants.KEY_ERROR_CODE).equals("0")) {
                                            int iIntValue3 = ((Integer) TDConfig.this.mConfigStoragePlugin.get(2)).intValue();
                                            iIntValue = ((Integer) TDConfig.this.mConfigStoragePlugin.get(1)).intValue();
                                            jSONObject2 = jSONObject.getJSONObject("data");
                                            int i5 = jSONObject2.getInt("sync_interval") * 1000;
                                            iIntValue = jSONObject2.getInt("sync_batch_size");
                                            if (jSONObject2.has("secret_key")) {
                                                jSONObject3 = jSONObject2.getJSONObject("secret_key");
                                                if (jSONObject3.has("key")) {
                                                    string = jSONObject3.getString("key");
                                                    i3 = jSONObject3.getInt("version");
                                                    string2 = jSONObject3.getString("symmetric");
                                                    string3 = jSONObject3.getString("asymmetric");
                                                    if (!TextUtils.isEmpty(string)) {
                                                        TDConfig.this.secreteKey = new TDSecreteKey(string, i3, string2, string3);
                                                    }
                                                }
                                            }
                                            if (TDConfig.this.enableAutoCalibrated) {
                                                jOptLong = jSONObject2.optLong("server_timestamp");
                                                if (jOptLong != 0) {
                                                    cn.thinkingdata.analytics.h.a.a(jOptLong + ((System.currentTimeMillis() - jCurrentTimeMillis) / 2));
                                                }
                                            }
                                            TDLog.i(TDConfig.TAG, "[ThinkingData] Info: Get remote config success (" + q.a(TDConfig.this.mToken, 4) + "):\n" + jSONObject2.toString(4));
                                            if (jSONObject2.has("disable_event_list")) {
                                                TDConfig.this.mDisabledEventsLock.writeLock().lock();
                                                jSONArray = jSONObject2.getJSONArray("disable_event_list");
                                                while (i2 < jSONArray.length()) {
                                                    TDConfig.this.mDisabledEvents.add(jSONArray.getString(i2));
                                                }
                                                TDConfig.this.mDisabledEventsLock.writeLock().unlock();
                                            }
                                            i = i5;
                                            if (((Integer) TDConfig.this.mConfigStoragePlugin.get(1)).intValue() != iIntValue) {
                                                TDConfig.this.mConfigStoragePlugin.save(1, Integer.valueOf(iIntValue));
                                            }
                                            if (((Integer) TDConfig.this.mConfigStoragePlugin.get(2)).intValue() != i) {
                                                TDConfig.this.mConfigStoragePlugin.save(2, Integer.valueOf(i));
                                            }
                                        }
                                        inputStream.close();
                                        bufferedReader.close();
                                    } else {
                                        str = "Getting remote config failed due to: ";
                                        httpURLConnection = httpURLConnection2;
                                        TDLog.d(TDConfig.TAG, "Getting remote config failed, responseCode is " + httpURLConnection.getResponseCode());
                                        inputStream = null;
                                    }
                                    if (inputStream != null) {
                                        inputStream.close();
                                    }
                                    if (httpURLConnection == null) {
                                        return;
                                    }
                                }
                            } catch (IOException e25) {
                                httpURLConnection = httpURLConnection2;
                                iOException = e25;
                                str2 = "Getting remote config failed due to: ";
                            } catch (JSONException e26) {
                                httpURLConnection = httpURLConnection2;
                                jSONException = e26;
                                str2 = "Getting remote config failed due to: ";
                            } catch (Exception e27) {
                                e = e27;
                                str = "Getting remote config failed due to: ";
                                httpURLConnection = httpURLConnection2;
                            } catch (Throwable th7) {
                                th = th7;
                                httpURLConnection = httpURLConnection2;
                            }
                        } catch (IOException e28) {
                            iOException = e28;
                            inputStream = null;
                            httpURLConnection = null;
                        } catch (JSONException e29) {
                            jSONException = e29;
                            inputStream = null;
                            httpURLConnection = null;
                            TDLog.d(TDConfig.TAG, str2 + jSONException.getMessage());
                            if (inputStream != null) {
                                inputStream.close();
                            }
                            if (httpURLConnection == null) {
                                return;
                            }
                            httpURLConnection.disconnect();
                        }
                    } catch (Throwable th8) {
                        th = th8;
                    }
                } catch (IOException e30) {
                    iOException = e30;
                } catch (JSONException e31) {
                    jSONException = e31;
                }
            } catch (Exception e32) {
                str = "Getting remote config failed due to: ";
                exc = e32;
                inputStream = null;
                httpURLConnection = null;
            } catch (Throwable th9) {
                th = th9;
                inputStream = null;
                httpURLConnection = null;
            }
            httpURLConnection.disconnect();
        }
    }

    static /* synthetic */ class b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f43a;
        static final /* synthetic */ int[] b;

        static {
            int[] iArr = new int[ThinkingAnalyticsSDK.ThinkingdataNetworkType.values().length];
            b = iArr;
            try {
                iArr[ThinkingAnalyticsSDK.ThinkingdataNetworkType.NETWORKTYPE_WIFI.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                b[ThinkingAnalyticsSDK.ThinkingdataNetworkType.NETWORKTYPE_DEFAULT.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                b[ThinkingAnalyticsSDK.ThinkingdataNetworkType.NETWORKTYPE_ALL.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            int[] iArr2 = new int[TDMode.values().length];
            f43a = iArr2;
            try {
                iArr2[TDMode.DEBUG.ordinal()] = 1;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                f43a[TDMode.DEBUG_ONLY.ordinal()] = 2;
            } catch (NoSuchFieldError unused5) {
            }
            try {
                f43a[TDMode.NORMAL.ordinal()] = 3;
            } catch (NoSuchFieldError unused6) {
            }
        }
    }

    private TDConfig(Context context, String str, String str2) {
        Context applicationContext = context.getApplicationContext();
        this.mContext = applicationContext;
        this.mToken = str;
        this.mServerUrl = str2 + "/sync";
        this.mDebugUrl = str2 + "/data_debug";
        this.mConfigUrl = str2 + "/config?appid=" + str;
        this.mConfigStoragePlugin = new cn.thinkingdata.analytics.f.c(applicationContext, str);
        this.mEnableMutiprocess = false;
        this.mDnsServiceManager = new cn.thinkingdata.analytics.h.b(str2);
    }

    public static TDConfig getInstance(Context context, String str) {
        try {
            return getInstance(context, str, "");
        } catch (IllegalArgumentException unused) {
            return null;
        }
    }

    public static TDConfig getInstance(Context context, String str, String str2) {
        return getInstance(context, str, str2, str);
    }

    public static TDConfig getInstance(Context context, String str, String str2, String str3) {
        TDConfig tDConfig;
        Context applicationContext = context.getApplicationContext();
        Map<Context, Map<String, TDConfig>> map = sInstances;
        synchronized (map) {
            Map<String, TDConfig> map2 = map.get(applicationContext);
            if (map2 == null) {
                map2 = new HashMap<>();
                map.put(applicationContext, map2);
            }
            String strReplace = str.replace(" ", "");
            String strReplace2 = str3.replace(" ", "");
            tDConfig = map2.get(strReplace2);
            if (tDConfig == null) {
                try {
                    URL url = new URL(str2);
                    TDConfig tDConfig2 = new TDConfig(applicationContext, strReplace, url.getProtocol() + "://" + url.getHost() + (url.getPort() > 0 ? ":" + url.getPort() : ""));
                    tDConfig2.setName(strReplace2);
                    map2.put(strReplace2, tDConfig2);
                    tDConfig2.getRemoteConfig();
                    tDConfig = tDConfig2;
                } catch (MalformedURLException e) {
                    TDLog.e(TAG, "Invalid server URL: " + str2);
                    throw new IllegalArgumentException(e);
                }
            }
        }
        return tDConfig;
    }

    private void getRemoteConfig() {
        new Thread(new a()).start();
    }

    private void setName(String str) {
        this.name = str;
    }

    public TDConfig enableAutoPush() {
        this.mEnableAutoPush = true;
        return this;
    }

    public TDConfig enableDNSService(List<TDDNSService> list) {
        this.mDnsServiceManager.a(list);
        this.mEnableDNS = true;
        return this;
    }

    public TDConfig enableEncrypt(int i, String str) {
        this.mEnableEncrypt = true;
        if (this.secreteKey == null) {
            TDSecreteKey tDSecreteKey = new TDSecreteKey();
            this.secreteKey = tDSecreteKey;
            tDSecreteKey.version = i;
            tDSecreteKey.publicKey = str;
            tDSecreteKey.asymmetricEncryption = d.f334a;
            tDSecreteKey.symmetricEncryption = "AES";
        }
        return this;
    }

    public TDConfig enableEncrypt(boolean z) {
        this.mEnableEncrypt = z;
        return this;
    }

    public String getDebugUrl() {
        return this.mDebugUrl;
    }

    public synchronized TimeZone getDefaultTimeZone() {
        TimeZone timeZone;
        timeZone = this.mDefaultTimeZone;
        if (timeZone == null) {
            timeZone = TimeZone.getDefault();
        }
        return timeZone;
    }

    public int getFlushBulkSize() {
        cn.thinkingdata.analytics.f.c cVar = this.mConfigStoragePlugin;
        if (cVar == null) {
            return 20;
        }
        return ((Integer) cVar.get(1)).intValue();
    }

    public int getFlushInterval() {
        cn.thinkingdata.analytics.f.c cVar = this.mConfigStoragePlugin;
        if (cVar == null) {
            return 15000;
        }
        return ((Integer) cVar.get(2)).intValue();
    }

    public ModeEnum getMode() {
        return this.mMode;
    }

    public String getName() {
        return this.name;
    }

    public synchronized SSLSocketFactory getSSLSocketFactory() {
        return this.mSSLSocketFactory;
    }

    public TDSecreteKey getSecreteKey() {
        return this.secreteKey;
    }

    public String getServerUrl() {
        return this.mServerUrl;
    }

    Map<String, TDConfig> getTDConfigMap() {
        return sInstances.get(this.mContext);
    }

    boolean isDebug() {
        return ModeEnum.DEBUG.equals(this.mMode);
    }

    public boolean isDebugOnly() {
        return ModeEnum.DEBUG_ONLY.equals(this.mMode);
    }

    boolean isDisabledEvent(String str) {
        this.mDisabledEventsLock.readLock().lock();
        try {
            return this.mDisabledEvents.contains(str);
        } finally {
            this.mDisabledEventsLock.readLock().unlock();
        }
    }

    public boolean isEnableMutiprocess() {
        return this.mEnableMutiprocess;
    }

    public boolean isNormal() {
        return ModeEnum.NORMAL.equals(this.mMode);
    }

    public synchronized boolean isShouldFlush(String str) {
        return (q.a(str) & this.mNetworkType) != 0;
    }

    public void setAllowDebug() {
        this.mAllowedDebug = true;
    }

    public synchronized TDConfig setDefaultTimeZone(TimeZone timeZone) {
        this.mDefaultTimeZone = timeZone;
        return this;
    }

    public TDConfig setMode(ModeEnum modeEnum) {
        this.mMode = modeEnum;
        return this;
    }

    public TDConfig setMode(TDMode tDMode) {
        ModeEnum modeEnum;
        int i = b.f43a[tDMode.ordinal()];
        if (i == 1) {
            modeEnum = ModeEnum.DEBUG;
        } else {
            if (i != 2) {
                if (i == 3) {
                    modeEnum = ModeEnum.NORMAL;
                }
                return this;
            }
            modeEnum = ModeEnum.DEBUG_ONLY;
        }
        this.mMode = modeEnum;
        return this;
    }

    public TDConfig setMutiprocess(boolean z) {
        this.mEnableMutiprocess = z;
        return this;
    }

    synchronized void setNetworkType(ThinkingAnalyticsSDK.ThinkingdataNetworkType thinkingdataNetworkType) {
        int i = b.b[thinkingdataNetworkType.ordinal()];
        if (i == 1) {
            this.mNetworkType = 8;
        } else if (i == 2 || i == 3) {
            this.mNetworkType = 31;
        }
    }

    public synchronized TDConfig setSSLSocketFactory(SSLSocketFactory sSLSocketFactory) {
        if (sSLSocketFactory != null) {
            this.mSSLSocketFactory = sSLSocketFactory;
            getRemoteConfig();
        }
        return this;
    }

    public TDConfig setSecretKey(TDSecreteKey tDSecreteKey) {
        if (this.secreteKey == null) {
            this.secreteKey = tDSecreteKey;
        }
        return this;
    }

    public TDConfig setTrackOldData(boolean z) {
        this.mTrackOldData = z;
        return this;
    }

    public boolean shouldThrowException() {
        return false;
    }

    public boolean trackOldData() {
        return this.mTrackOldData;
    }
}
