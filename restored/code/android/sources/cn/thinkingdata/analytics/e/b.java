package cn.thinkingdata.analytics.e;

import android.content.Context;
import android.os.Handler;
import android.os.HandlerThread;
import android.os.Looper;
import android.os.Message;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.thinkingdata.analytics.TDConfig;
import cn.thinkingdata.analytics.TDPresetProperties;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.analytics.h.h;
import cn.thinkingdata.analytics.h.l;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.preset.TDPresetUtils;
import cn.thinkingdata.core.receiver.TDAnalyticsObservable;
import cn.thinkingdata.core.utils.TDLog;
import com.byazt.nys.PluginConstants;
import java.io.IOException;
import java.net.URLEncoder;
import java.nio.charset.MalformedInputException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Locale;
import java.util.Map;
import java.util.UUID;
import java.util.concurrent.ConcurrentHashMap;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class b {
    private static final Map<Context, b> f = new HashMap();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final C0021b f88a;
    private final a b;
    private final c c;
    private final Context d;
    private final Map<String, Boolean> e = new ConcurrentHashMap();

    private class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final Handler f89a;

        /* JADX INFO: renamed from: cn.thinkingdata.analytics.e.b$a$a, reason: collision with other inner class name */
        private class HandlerC0020a extends Handler {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            private final List<String> f90a;

            HandlerC0020a(Looper looper) {
                super(looper);
                this.f90a = new ArrayList();
            }

            @Override // android.os.Handler
            public void handleMessage(Message message) {
                int iA;
                int i = message.what;
                if (i != 0) {
                    if (i != 1) {
                        if (i == 2) {
                            b.this.f88a.c((String) message.obj);
                            return;
                        } else {
                            if (i == 3) {
                                this.f90a.remove((String) message.obj);
                                return;
                            }
                            return;
                        }
                    }
                    String str = (String) message.obj;
                    if (str == null) {
                        return;
                    }
                    b.this.f88a.a(str);
                    synchronized (a.this.f89a) {
                        a.this.f89a.removeMessages(2, str);
                        this.f90a.add(str);
                    }
                    synchronized (b.this.c) {
                        b.this.c.a(c.EnumC0022c.EVENTS, (String) message.obj);
                    }
                    return;
                }
                try {
                    cn.thinkingdata.analytics.e.a aVar = (cn.thinkingdata.analytics.e.a) message.obj;
                    if (aVar == null) {
                        return;
                    }
                    String str2 = aVar.k;
                    if (this.f90a.contains(str2)) {
                        return;
                    }
                    JSONObject jSONObjectA = aVar.a();
                    try {
                        jSONObjectA.put("#uuid", UUID.randomUUID().toString());
                    } catch (JSONException unused) {
                    }
                    synchronized (b.this.c) {
                        iA = b.this.c.a(jSONObjectA, c.EnumC0022c.EVENTS, str2);
                    }
                    TDConfig tDConfigD = b.this.d(str2);
                    if (tDConfigD != null) {
                        TDAnalyticsObservable.getInstance().onDataEnqueued(tDConfigD.mToken, jSONObjectA);
                    }
                    if (iA < 0) {
                        TDLog.w("ThinkingAnalytics.DataHandle", "Saving data to database failed.");
                    } else {
                        TDLog.i("ThinkingAnalytics.DataHandle", "[ThinkingData] Info: Enqueue data(" + q.a(str2, 4) + "):\n" + jSONObjectA.toString(4));
                    }
                    if (aVar.j) {
                        return;
                    }
                    a.this.a(str2, iA);
                } catch (Exception e) {
                    TDLog.w("ThinkingAnalytics.DataHandle", "Exception occurred while saving data to database: " + e.getMessage());
                    e.printStackTrace();
                }
            }
        }

        a() {
            HandlerThread handlerThread = new HandlerThread("thinkingData.sdk.saveMessageWorker", 1);
            handlerThread.start();
            this.f89a = new HandlerC0020a(handlerThread.getLooper());
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void a(String str, int i) {
            if (i >= b.this.e(str)) {
                b.this.f88a.c(str);
            } else {
                b.this.f88a.a(str, b.this.f(str));
            }
        }

        void a(cn.thinkingdata.analytics.e.a aVar) {
            Message messageObtain = Message.obtain();
            messageObtain.what = 0;
            messageObtain.obj = aVar;
            Handler handler = this.f89a;
            if (handler != null) {
                handler.sendMessage(messageObtain);
            }
        }

        void a(String str) {
            Message messageObtain = Message.obtain();
            messageObtain.what = 1;
            messageObtain.obj = str;
            Handler handler = this.f89a;
            if (handler != null) {
                handler.sendMessageAtFrontOfQueue(messageObtain);
            }
            Message messageObtain2 = Message.obtain();
            messageObtain2.what = 3;
            messageObtain2.obj = str;
            Handler handler2 = this.f89a;
            if (handler2 != null) {
                handler2.sendMessage(messageObtain2);
            }
        }

        void b(String str) {
            Message messageObtain = Message.obtain();
            messageObtain.what = 2;
            messageObtain.obj = str;
            this.f89a.sendMessage(messageObtain);
        }
    }

    /* JADX INFO: renamed from: cn.thinkingdata.analytics.e.b$b, reason: collision with other inner class name */
    private class C0021b {
        private final Handler b;
        private final h c;

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final Object f91a = new Object();
        private final Map<String, Boolean> d = new HashMap();

        /* JADX INFO: renamed from: cn.thinkingdata.analytics.e.b$b$a */
        private class a extends Handler {
            a(Looper looper) {
                super(looper);
            }

            @Override // android.os.Handler
            public void handleMessage(Message message) throws Throwable {
                C0021b c0021b;
                int i = message.what;
                if (i == 0) {
                    String str = (String) message.obj;
                    TDConfig tDConfigD = b.this.d(str);
                    if (tDConfigD != null) {
                        synchronized (C0021b.this.f91a) {
                            Message messageObtain = Message.obtain();
                            messageObtain.what = 1;
                            messageObtain.obj = str;
                            C0021b.this.b.sendMessage(messageObtain);
                            removeMessages(0, str);
                        }
                        try {
                            C0021b.this.a(tDConfigD);
                        } catch (RuntimeException e) {
                            TDLog.w("ThinkingAnalytics.DataHandle", "Sending data to server failed due to unexpected exception: " + e.getMessage());
                            e.printStackTrace();
                        }
                        synchronized (C0021b.this.f91a) {
                            removeMessages(1, str);
                            C0021b c0021b2 = C0021b.this;
                            c0021b2.a(str, b.this.f(str));
                        }
                        return;
                    }
                } else {
                    if (i != 2) {
                        if (i == 3) {
                            if (((String) message.obj) == null) {
                                return;
                            }
                            synchronized (C0021b.this.f91a) {
                                removeMessages(0, message.obj);
                            }
                            return;
                        }
                        if (i == 4) {
                            try {
                                cn.thinkingdata.analytics.e.a aVar = (cn.thinkingdata.analytics.e.a) message.obj;
                                if (aVar == null) {
                                    return;
                                }
                                JSONObject jSONObjectA = aVar.a();
                                C0021b c0021b3 = C0021b.this;
                                c0021b3.a(b.this.d(aVar.k), jSONObjectA);
                                return;
                            } catch (Exception e2) {
                                TDLog.e("ThinkingAnalytics.DataHandle", "Exception occurred while sending message to Server: " + e2.getMessage());
                                return;
                            }
                        }
                        if (i != 5) {
                            if (i != 6) {
                                return;
                            }
                            f fVarA = f.a(b.this.d);
                            synchronized (b.this.c) {
                                b.this.c.a(System.currentTimeMillis() - fVarA.a(), c.EnumC0022c.EVENTS);
                            }
                            return;
                        }
                        try {
                            cn.thinkingdata.analytics.e.a aVar2 = (cn.thinkingdata.analytics.e.a) message.obj;
                            if (aVar2 == null) {
                                return;
                            }
                            TDConfig tDConfigD2 = b.this.d(aVar2.k);
                            if (!tDConfigD2.isNormal() || aVar2.b == 2) {
                                try {
                                    JSONObject jSONObjectA2 = aVar2.a();
                                    TDAnalyticsObservable.getInstance().onDataEnqueued(tDConfigD2.mToken, jSONObjectA2);
                                    C0021b.this.a(tDConfigD2, jSONObjectA2, aVar2.b);
                                    return;
                                } catch (Exception e3) {
                                    TDLog.e("ThinkingAnalytics.DataHandle", "Exception occurred while sending message to Server: " + e3.getMessage());
                                    if (tDConfigD2.shouldThrowException()) {
                                        throw new l(e3);
                                    }
                                    if (tDConfigD2.isDebugOnly()) {
                                        return;
                                    } else {
                                        c0021b = C0021b.this;
                                    }
                                }
                            } else {
                                c0021b = C0021b.this;
                            }
                            b.this.c(aVar2);
                            return;
                        } catch (Exception e4) {
                            e4.printStackTrace();
                            return;
                        }
                    }
                    TDConfig tDConfigD3 = b.this.d((String) message.obj);
                    if (tDConfigD3 != null) {
                        try {
                            C0021b.this.a("", tDConfigD3);
                            return;
                        } catch (RuntimeException e5) {
                            TDLog.w("ThinkingAnalytics.DataHandle", "Sending old data failed due to unexpected exception: " + e5.getMessage());
                            e5.printStackTrace();
                            return;
                        }
                    }
                }
                TDLog.w("ThinkingAnalytics.DataHandle", "Could found config object for token. Canceling...");
            }
        }

        C0021b() {
            HandlerThread handlerThread = new HandlerThread("thinkingData.sdk.sendMessageWorker", 1);
            handlerThread.start();
            this.b = new a(handlerThread.getLooper());
            this.c = b.this.a();
        }

        private Map<String, String> a(JSONArray jSONArray) {
            HashMap map = new HashMap();
            map.put("TA-Integration-Type", e.g());
            map.put("TA-Integration-Version", e.h());
            map.put("TA-Integration-Count", String.valueOf(jSONArray.length()));
            map.put("TA-Integration-Extra", Constants.LOG_OS);
            map.put("TA-Datas-Type", cn.thinkingdata.analytics.encrypt.c.a(jSONArray) ? "1" : "0");
            return map;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void a(TDConfig tDConfig) throws Throwable {
            a(tDConfig.getName(), tDConfig);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void a(TDConfig tDConfig, JSONObject jSONObject) throws JSONException {
            if (TextUtils.isEmpty(tDConfig.mToken)) {
                return;
            }
            JSONArray jSONArray = new JSONArray();
            jSONArray.put(jSONObject);
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("data", jSONArray);
            jSONObject2.put("#app_id", tDConfig.mToken);
            jSONObject2.put("#flush_time", System.currentTimeMillis());
            TDLog.i("ThinkingAnalytics.DataHandle", "ret code: " + new JSONObject(this.c.a(tDConfig, jSONObject2.toString(), d("1"))).getString(PluginConstants.KEY_ERROR_CODE) + ", upload message:\n" + jSONObject2.toString(4));
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void a(TDConfig tDConfig, JSONObject jSONObject, int i) throws JSONException {
            StringBuilder sb = new StringBuilder("appid=");
            sb.append(tDConfig.mToken);
            if (jSONObject.optJSONObject("properties") != null) {
                TDPresetProperties presetProperties = ThinkingAnalyticsSDK.sharedInstance(tDConfig).getPresetProperties();
                String strD = (presetProperties == null || TDPresetProperties.disableList.contains(TDPresetUtils.KEY_DEVICE_ID)) ? "" : presetProperties.deviceId;
                if (TextUtils.isEmpty(strD) && !TDPresetProperties.disableList.contains(TDPresetUtils.KEY_DEVICE_ID)) {
                    strD = e.b(tDConfig.mContext).d();
                }
                if (!TextUtils.isEmpty(strD)) {
                    sb.append("&deviceId=");
                    sb.append(strD);
                }
            }
            sb.append("&source=client&data=");
            sb.append(URLEncoder.encode(jSONObject.toString()));
            if (tDConfig.isDebugOnly() || i == 2) {
                sb.append("&dryRun=1");
            }
            String strA = q.a(tDConfig.getName(), 4);
            TDLog.i("ThinkingAnalytics.DataHandle", "uploading message(" + strA + "):\n" + jSONObject.toString(4));
            JSONObject jSONObject2 = new JSONObject(this.c.a(tDConfig, sb.toString(), d("1")));
            int i2 = jSONObject2.getInt("errorLevel");
            if (i2 == -1) {
                if (tDConfig.isDebugOnly()) {
                    TDLog.w("ThinkingAnalytics.DataHandle", "The data will be discarded due to this device is not allowed to debug for: " + strA);
                    return;
                } else {
                    tDConfig.setMode(TDConfig.TDMode.NORMAL);
                    throw new l("Fallback to normal mode due to the device is not allowed to debug for: " + strA);
                }
            }
            Boolean bool = this.d.get(tDConfig.getName());
            if (bool == null || !bool.booleanValue()) {
                this.d.put(tDConfig.getName(), true);
                tDConfig.setAllowDebug();
            }
            if (i2 == 0) {
                TDLog.d("ThinkingAnalytics.DataHandle", "Upload debug data successfully for " + strA);
                return;
            }
            try {
                if (jSONObject2.has("errorProperties")) {
                    TDLog.d("ThinkingAnalytics.DataHandle", " Error Properties: \n" + jSONObject2.getJSONArray("errorProperties").toString(4));
                }
                if (jSONObject2.has("errorReasons")) {
                    TDLog.d("ThinkingAnalytics.DataHandle", "Error Reasons: \n" + jSONObject2.getJSONArray("errorReasons").toString(4));
                }
            } catch (Exception unused) {
            }
            if (tDConfig.shouldThrowException()) {
                if (1 == i2) {
                    throw new l("Invalid properties. Please refer to the logcat log for detail info.");
                }
                if (2 != i2) {
                    throw new l("Unknown error level: " + i2);
                }
                throw new l("Invalid data format. Please refer to the logcat log for detail info.");
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        /* JADX WARN: Code duplicated, block: B:106:0x0250 A[PHI: r0
  0x0250: PHI (r0v16 java.lang.String) = (r0v13 java.lang.String), (r0v20 java.lang.String) binds: [B:105:0x024e, B:85:0x01cb] A[DONT_GENERATE, DONT_INLINE]] */
        /* JADX WARN: Code duplicated, block: B:111:0x025e  */
        /* JADX WARN: Code duplicated, block: B:113:0x0265  */
        /* JADX WARN: Code duplicated, block: B:138:0x026c A[EXC_TOP_SPLITTER, SYNTHETIC] */
        public void a(String str, TDConfig tDConfig) throws Throwable {
            Boolean bool;
            String[] strArrA;
            int i;
            String str2;
            boolean z;
            int iA;
            String str3;
            if (tDConfig == null) {
                TDLog.w("ThinkingAnalytics.DataHandle", "Could found config object for sendToken. Canceling...");
                return;
            }
            if (TextUtils.isEmpty(tDConfig.mToken)) {
                return;
            }
            synchronized (b.this.e) {
                bool = (Boolean) b.this.e.get(str);
            }
            if (bool == null || !bool.booleanValue()) {
                try {
                    if (!e.b(b.this.d).f() || !tDConfig.isShouldFlush(e.b(b.this.d).c())) {
                        return;
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
                do {
                    synchronized (b.this.c) {
                        strArrA = b.this.c.a(c.EnumC0022c.EVENTS, str, 50);
                    }
                    if (strArrA == null) {
                        return;
                    }
                    i = 0;
                    String str4 = strArrA[0];
                    String str5 = strArrA[1];
                    try {
                        try {
                            try {
                                try {
                                    try {
                                        JSONArray jSONArray = new JSONArray(str5);
                                        try {
                                            JSONObject jSONObject = new JSONObject();
                                            try {
                                                jSONObject.put("data", jSONArray);
                                                jSONObject.put("#app_id", tDConfig.mToken);
                                                jSONObject.put("#flush_time", System.currentTimeMillis());
                                                try {
                                                    JSONObject jSONObject2 = new JSONObject(this.c.a(tDConfig, jSONObject.toString(), a(jSONArray)));
                                                    jSONObject2.getString(PluginConstants.KEY_ERROR_CODE);
                                                    TDLog.i("ThinkingAnalytics.DataHandle", "[ThinkingData] Debug: Send event, Request = " + jSONObject.toString(4));
                                                    TDLog.i("ThinkingAnalytics.DataHandle", "[ThinkingData] Debug: Send event, Response =" + jSONObject2.toString(4));
                                                    if (!TextUtils.isEmpty(null)) {
                                                        TDLog.e("ThinkingAnalytics.DataHandle", null);
                                                    }
                                                    synchronized (b.this.c) {
                                                        iA = b.this.c.a(str4, c.EnumC0022c.EVENTS, str);
                                                    }
                                                    str3 = String.format(Locale.CHINA, "Events flushed. [left = %d]", Integer.valueOf(iA));
                                                } catch (MalformedInputException unused) {
                                                    z = true;
                                                    try {
                                                        String str6 = "Cannot interpret " + tDConfig.getServerUrl() + " as a URL. The data will be deleted.";
                                                        if (!TextUtils.isEmpty(str6)) {
                                                            TDLog.e("ThinkingAnalytics.DataHandle", str6);
                                                        }
                                                        if (z) {
                                                            synchronized (b.this.c) {
                                                                iA = b.this.c.a(str4, c.EnumC0022c.EVENTS, str);
                                                            }
                                                            str3 = String.format(Locale.CHINA, "Events flushed. [left = %d]", Integer.valueOf(iA));
                                                        }
                                                    } catch (Throwable th) {
                                                        th = th;
                                                        if (!TextUtils.isEmpty(null)) {
                                                            TDLog.e("ThinkingAnalytics.DataHandle", null);
                                                        }
                                                        if (z) {
                                                            synchronized (b.this.c) {
                                                                int iA2 = b.this.c.a(str4, c.EnumC0022c.EVENTS, str);
                                                            }
                                                            TDLog.i("ThinkingAnalytics.DataHandle", String.format(Locale.CHINA, "Events flushed. [left = %d]", Integer.valueOf(iA2)));
                                                        }
                                                        throw th;
                                                    }
                                                } catch (Throwable th2) {
                                                    th = th2;
                                                    z = true;
                                                    if (!TextUtils.isEmpty(null)) {
                                                        TDLog.e("ThinkingAnalytics.DataHandle", null);
                                                    }
                                                    if (z) {
                                                        synchronized (b.this.c) {
                                                            int iA3 = b.this.c.a(str4, c.EnumC0022c.EVENTS, str);
                                                            TDLog.i("ThinkingAnalytics.DataHandle", String.format(Locale.CHINA, "Events flushed. [left = %d]", Integer.valueOf(iA3)));
                                                        }
                                                    }
                                                    throw th;
                                                }
                                            } catch (JSONException e2) {
                                                TDLog.w("ThinkingAnalytics.DataHandle", "Invalid data: " + jSONObject.toString());
                                                throw e2;
                                            }
                                        } catch (JSONException unused2) {
                                            if (!TextUtils.isEmpty("Cannot post message due to JSONException, the data will be deleted")) {
                                                TDLog.e("ThinkingAnalytics.DataHandle", "Cannot post message due to JSONException, the data will be deleted");
                                            }
                                            synchronized (b.this.c) {
                                                iA = b.this.c.a(str4, c.EnumC0022c.EVENTS, str);
                                                str3 = String.format(Locale.CHINA, "Events flushed. [left = %d]", Integer.valueOf(iA));
                                            }
                                        }
                                    } catch (Throwable th3) {
                                        th = th3;
                                        z = false;
                                    }
                                } catch (MalformedInputException unused3) {
                                    z = false;
                                }
                                TDLog.i("ThinkingAnalytics.DataHandle", str3);
                                i = iA;
                            } catch (IOException e3) {
                                str2 = "Cannot post message to [" + tDConfig.getServerUrl() + "] due to " + e3.getMessage();
                                if (!TextUtils.isEmpty(str2)) {
                                    TDLog.e("ThinkingAnalytics.DataHandle", str2);
                                }
                            }
                        } catch (JSONException e4) {
                            TDLog.w("ThinkingAnalytics.DataHandle", "The data is invalid: " + str5);
                            throw e4;
                        }
                    } catch (h.a e5) {
                        str2 = "Cannot post message to [" + tDConfig.getServerUrl() + "] due to " + e5.getMessage();
                        if (!TextUtils.isEmpty(str2)) {
                            TDLog.e("ThinkingAnalytics.DataHandle", str2);
                        }
                    }
                } while (i > 0);
            }
        }

        private Map<String, String> d(String str) {
            HashMap map = new HashMap();
            map.put("TA-Integration-Type", e.g());
            map.put("TA-Integration-Version", e.h());
            map.put("TA-Integration-Count", str);
            map.put("TA-Integration-Extra", Constants.LOG_OS);
            return map;
        }

        void a() {
            Message messageObtain = Message.obtain();
            messageObtain.what = 6;
            this.b.sendMessage(messageObtain);
        }

        void a(cn.thinkingdata.analytics.e.a aVar) {
            if (aVar == null) {
                return;
            }
            Message messageObtain = Message.obtain();
            messageObtain.what = 5;
            messageObtain.obj = aVar;
            if (aVar.j) {
                return;
            }
            this.b.sendMessage(messageObtain);
        }

        void a(String str) {
            if (TextUtils.isEmpty(str)) {
                return;
            }
            Message messageObtain = Message.obtain();
            messageObtain.what = 3;
            messageObtain.obj = str;
            this.b.sendMessageAtFrontOfQueue(messageObtain);
        }

        void a(String str, long j) {
            synchronized (this.f91a) {
                Handler handler = this.b;
                if (handler != null && !handler.hasMessages(0, str) && !this.b.hasMessages(1, str)) {
                    Message messageObtain = Message.obtain();
                    messageObtain.what = 0;
                    messageObtain.obj = str;
                    try {
                        this.b.sendMessageDelayed(messageObtain, j);
                    } catch (IllegalStateException e) {
                        TDLog.w("ThinkingAnalytics.DataHandle", "The app might be quiting: " + e.getMessage());
                    }
                }
            }
        }

        void b(cn.thinkingdata.analytics.e.a aVar) {
            if (aVar == null) {
                return;
            }
            Message messageObtain = Message.obtain();
            messageObtain.what = 4;
            messageObtain.obj = aVar;
            if (aVar.j) {
                return;
            }
            this.b.sendMessage(messageObtain);
        }

        void b(String str) {
            if (TextUtils.isEmpty(str)) {
                return;
            }
            Message messageObtain = Message.obtain();
            messageObtain.what = 2;
            messageObtain.obj = str;
            this.b.sendMessage(messageObtain);
        }

        void c(String str) {
            synchronized (this.f91a) {
                Handler handler = this.b;
                if (handler != null && !handler.hasMessages(1, str)) {
                    Message messageObtain = Message.obtain();
                    messageObtain.what = 0;
                    messageObtain.obj = str;
                    this.b.sendMessage(messageObtain);
                }
            }
        }
    }

    b(Context context) {
        Context applicationContext = context.getApplicationContext();
        this.d = applicationContext;
        this.c = a(applicationContext);
        C0021b c0021b = new C0021b();
        this.f88a = c0021b;
        this.b = new a();
        c0021b.a();
    }

    public static b b(Context context) {
        b bVar;
        Map<Context, b> map = f;
        synchronized (map) {
            Context applicationContext = context.getApplicationContext();
            if (map.containsKey(applicationContext)) {
                bVar = map.get(applicationContext);
            } else {
                bVar = new b(applicationContext);
                map.put(applicationContext, bVar);
            }
        }
        return bVar;
    }

    protected c a(Context context) {
        return c.a(context);
    }

    protected h a() {
        return new cn.thinkingdata.analytics.h.c();
    }

    public void a(cn.thinkingdata.analytics.e.a aVar) {
        if (aVar.j) {
            return;
        }
        this.f88a.b(aVar);
    }

    public void a(String str) {
        this.b.a(str);
    }

    public void a(String str, boolean z) {
        synchronized (this.e) {
            try {
                if (z) {
                    this.e.put(str, true);
                } else {
                    this.e.remove(str);
                }
            } catch (Throwable th) {
                throw th;
            }
        }
    }

    public void b(cn.thinkingdata.analytics.e.a aVar) {
        if (aVar.j) {
            return;
        }
        this.f88a.a(aVar);
    }

    public void b(String str) {
        this.b.b(str);
    }

    public void c(cn.thinkingdata.analytics.e.a aVar) {
        this.b.a(aVar);
    }

    public void c(String str) {
        this.f88a.b(str);
    }

    protected TDConfig d(String str) {
        return TDConfig.getInstance(this.d, str);
    }

    protected int e(String str) {
        TDConfig tDConfigD = d(str);
        if (tDConfigD == null) {
            return 20;
        }
        return tDConfigD.getFlushBulkSize();
    }

    protected int f(String str) {
        TDConfig tDConfigD = d(str);
        if (tDConfigD == null) {
            return 15000;
        }
        return tDConfigD.getFlushInterval();
    }
}
