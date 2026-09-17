package cn.com.chinatelecom.account.api.utils;

import android.content.Context;
import cn.com.chinatelecom.account.api.CtAuth;
import cn.com.chinatelecom.account.logging.LogManager;
import com.alipay.sdk.m.y.o;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Timer;
import java.util.TimerTask;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class LogUtils {
    private static final int IDLE = 0;
    private static final String TAG = "LogUtils";
    private static final int UPLOADING = 1;
    private static int state;
    private static Map<String, LogEntity> logMap = new HashMap();
    private static List<LogEntity> uploadList = new ArrayList();
    private static LogEntity mDnsLogEntity = null;

    public static synchronized LogEntity build(String str) {
        LogEntity logEntity;
        try {
            logEntity = logMap.containsKey(str) ? logMap.get(str) : null;
            if (logEntity == null) {
                logEntity = new LogEntity(str);
                logMap.put(str, logEntity);
            }
        } catch (Throwable th) {
            th.printStackTrace();
            return new LogEntity(str);
        }
        return logEntity;
    }

    public static synchronized void appendInitLog(String str) {
        try {
            if (logMap.containsKey(str)) {
                LogEntity logEntity = logMap.get(str);
                mDnsLogEntity = logEntity;
                logEntity.finish();
                logMap.remove(str);
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    public static synchronized void putExLog(String str, JSONObject jSONObject, String str2) {
        try {
            if (logMap.containsKey(str)) {
                logMap.get(str).putException(str2);
                return;
            }
            if (uploadList.size() > 0) {
                for (LogEntity logEntity : uploadList) {
                    if (logEntity.getReqId() != null && logEntity.getReqId().equals(str) && jSONObject != null) {
                        jSONObject.remove("data");
                        logEntity.putException(jSONObject.toString());
                        logEntity.putException(str2);
                    }
                }
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    public static void upload(String str) {
        try {
            synchronized (LogUtils.class) {
                if (logMap.containsKey(str)) {
                    LogEntity logEntity = logMap.get(str);
                    logEntity.finish();
                    uploadList.add(logEntity);
                    logMap.remove(str);
                }
                if (state != 1 && !uploadList.isEmpty()) {
                    state = 1;
                    new Timer().schedule(new TimerTask() { // from class: cn.com.chinatelecom.account.api.utils.LogUtils.1
                        @Override // java.util.TimerTask, java.lang.Runnable
                        public void run() {
                            LogUtils.doUpload(CtAuth.mContext);
                        }
                    }, 8000L);
                }
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void doUpload(Context context) {
        if (context == null) {
            return;
        }
        try {
            ArrayList arrayList = new ArrayList();
            synchronized (LogUtils.class) {
                LogEntity logEntity = mDnsLogEntity;
                if (logEntity != null) {
                    arrayList.add(logEntity.toString());
                    mDnsLogEntity = null;
                }
                Iterator<LogEntity> it = uploadList.iterator();
                while (it.hasNext()) {
                    arrayList.add(it.next().toString());
                }
                state = 0;
                uploadList.clear();
            }
            if (arrayList.isEmpty()) {
                return;
            }
            LogManager.uploadLog(context, arrayList);
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    public static void clearParams(String str) {
        try {
            build(str).setParams("");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void setResultAndMsg(String str, JSONObject jSONObject, String str2) {
        try {
            int iOptInt = jSONObject.optInt(o.c);
            String strOptString = jSONObject.optString("msg");
            if (iOptInt == 0) {
                build(str).setResult(iOptInt).setMsg(strOptString);
            } else {
                build(str).setResult(iOptInt).setMsg(strOptString).setParams(str2);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void setLogControl(Context context, String str) {
        LogManager.setLogControl(context, str);
    }
}
