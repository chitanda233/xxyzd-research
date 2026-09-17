package cn.com.chinatelecom.account.logging;

import android.content.Context;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.Helper;
import cn.com.chinatelecom.account.api.encrypt.StringUtil;
import cn.com.chinatelecom.account.api.net.BaseManager;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.com.chinatelecom.account.api.utils.DefaultShared;
import cn.com.chinatelecom.account.api.utils.NetUtil;
import com.byazt.nys.PluginConstants;
import java.net.URLEncoder;
import java.util.Iterator;
import java.util.List;
import java.util.Queue;
import java.util.concurrent.ConcurrentLinkedQueue;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class LogManager extends BaseManager {
    public static final int LOG_ALL = 0;
    public static final int LOG_ERROR = -1;
    private static final int LOG_MAX_SIZE = 10;
    public static final int LOG_OFF = -2;
    public static final String SEPARATOR = "_ABCDEFG_";
    private static final String TAG = "LogManager";

    public static void uploadLog(Context context, List<String> list) {
        int logControl = getLogControl(context);
        if (logControl == -2) {
            return;
        }
        doUploadLog(context, list, logControl);
    }

    private static void doUploadLog(final Context context, final List<String> list, final int i) {
        execute(new Runnable() { // from class: cn.com.chinatelecom.account.logging.LogManager.1
            @Override // java.lang.Runnable
            public void run() throws JSONException {
                try {
                    Queue queueFromFile = LogManager.getQueueFromFile(context, list, i);
                    if (queueFromFile.isEmpty()) {
                        return;
                    }
                    String strRequestUploadLog = LogManager.requestUploadLog(context, (Queue<String>) queueFromFile);
                    JSONObject jSONObject = null;
                    int i2 = -1;
                    try {
                        if (!TextUtils.isEmpty(strRequestUploadLog)) {
                            JSONObject jSONObject2 = new JSONObject(strRequestUploadLog);
                            try {
                                i2 = jSONObject2.getInt(PluginConstants.KEY_ERROR_CODE);
                                jSONObject = jSONObject2;
                            } catch (Exception e) {
                                e = e;
                                jSONObject = jSONObject2;
                                e.printStackTrace();
                            }
                        }
                    } catch (Exception e2) {
                        e = e2;
                    }
                    if (jSONObject != null && i2 == 0) {
                        LogManager.cleanLogFile(context);
                        queueFromFile.clear();
                    } else {
                        LogManager.saveLogToFile(context, queueFromFile, i);
                    }
                } catch (Throwable th) {
                    th.printStackTrace();
                }
            }
        });
    }

    private static void setLogControl(Context context, int i) {
        try {
            DefaultShared.putInt(context, Constants.LOG_CONTROL_LOG, i);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /* JADX WARN: switch over string: strings are not added: [[ALL]] */
    public static void setLogControl(Context context, String str) {
        str.hashCode();
        int i = 0;
        switch (str) {
            case "OFF":
                i = -2;
                break;
            case "ERROR":
                i = -1;
                break;
        }
        setLogControl(context, i);
    }

    private static int getLogControl(Context context) {
        try {
            return DefaultShared.getInt(context, Constants.LOG_CONTROL_LOG, 0);
        } catch (Throwable th) {
            th.printStackTrace();
            return 0;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:20:0x004c A[Catch: all -> 0x0083, TryCatch #1 {, blocks: (B:4:0x0003, B:6:0x0014, B:7:0x0021, B:10:0x002f, B:12:0x0035, B:13:0x003c, B:14:0x003f, B:17:0x0046, B:20:0x004c, B:21:0x0050, B:23:0x0056, B:24:0x005c, B:26:0x0069, B:29:0x006e, B:32:0x0077, B:34:0x007d, B:31:0x0074), top: B:43:0x0003, inners: #0, #2 }] */
    /* JADX WARN: Code duplicated, block: B:23:0x0056 A[Catch: all -> 0x0083, TRY_LEAVE, TryCatch #1 {, blocks: (B:4:0x0003, B:6:0x0014, B:7:0x0021, B:10:0x002f, B:12:0x0035, B:13:0x003c, B:14:0x003f, B:17:0x0046, B:20:0x004c, B:21:0x0050, B:23:0x0056, B:24:0x005c, B:26:0x0069, B:29:0x006e, B:32:0x0077, B:34:0x007d, B:31:0x0074), top: B:43:0x0003, inners: #0, #2 }] */
    /* JADX WARN: Code duplicated, block: B:30:0x0072 A[DONT_INVERT] */
    /* JADX WARN: Code duplicated, block: B:31:0x0074 A[Catch: all -> 0x0083, TryCatch #1 {, blocks: (B:4:0x0003, B:6:0x0014, B:7:0x0021, B:10:0x002f, B:12:0x0035, B:13:0x003c, B:14:0x003f, B:17:0x0046, B:20:0x004c, B:21:0x0050, B:23:0x0056, B:24:0x005c, B:26:0x0069, B:29:0x006e, B:32:0x0077, B:34:0x007d, B:31:0x0074), top: B:43:0x0003, inners: #0, #2 }] */
    /* JADX WARN: Code duplicated, block: B:34:0x007d A[Catch: all -> 0x0083, LOOP:2: B:32:0x0077->B:34:0x007d, LOOP_END, TRY_LEAVE, TryCatch #1 {, blocks: (B:4:0x0003, B:6:0x0014, B:7:0x0021, B:10:0x002f, B:12:0x0035, B:13:0x003c, B:14:0x003f, B:17:0x0046, B:20:0x004c, B:21:0x0050, B:23:0x0056, B:24:0x005c, B:26:0x0069, B:29:0x006e, B:32:0x0077, B:34:0x007d, B:31:0x0074), top: B:43:0x0003, inners: #0, #2 }] */
    /* JADX WARN: Code duplicated, block: B:52:0x0069 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:54:0x0050 A[SYNTHETIC] */
    public static synchronized Queue<String> getQueueFromFile(Context context, List<String> list, int i) {
        ConcurrentLinkedQueue concurrentLinkedQueue;
        concurrentLinkedQueue = new ConcurrentLinkedQueue();
        String logString = LogFileUtils.getLogString(context);
        if (!TextUtils.isEmpty(logString)) {
            try {
                JSONArray jSONArray = new JSONArray(new String(Helper.dneulret(StringUtil.hexToBytes(logString))));
                int length = jSONArray.length();
                for (int i2 = 0; i2 < length && i2 <= 10; i2++) {
                    JSONObject jSONObject = jSONArray.getJSONObject(i2);
                    if (jSONObject != null) {
                        concurrentLinkedQueue.add(jSONObject.toString());
                    }
                }
                LogFileUtils.saveLogToFile(context, "");
            } catch (Exception e) {
                e.printStackTrace();
            }
            if (i == -1) {
                for (String str : list) {
                    try {
                        if (new JSONObject(str).getInt("rt") != 0) {
                            concurrentLinkedQueue.add(str);
                        }
                    } catch (Exception e2) {
                        e2.printStackTrace();
                    }
                }
            } else if (i == 0) {
                concurrentLinkedQueue.addAll(list);
            }
            while (concurrentLinkedQueue.size() > 10) {
                concurrentLinkedQueue.poll();
            }
        } else {
            if (i == -1) {
                while (r7.hasNext()) {
                    if (new JSONObject(str).getInt("rt") != 0) {
                        concurrentLinkedQueue.add(str);
                    }
                }
            } else if (i == 0) {
                concurrentLinkedQueue.addAll(list);
            }
            while (concurrentLinkedQueue.size() > 10) {
                concurrentLinkedQueue.poll();
            }
        }
        throw th;
        return concurrentLinkedQueue;
    }

    private static String requestUploadLog(Context context, String str) {
        return HttpUploadUtil.doPost(context, NetUtil.getUploadLogUrl(), str);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static String requestUploadLog(Context context, Queue<String> queue) {
        JSONArray jSONArray = new JSONArray();
        String string = jSONArray.toString();
        if (!queue.isEmpty()) {
            Iterator<String> it = queue.iterator();
            while (it.hasNext()) {
                try {
                    jSONArray.put(new JSONObject(it.next()));
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }
        if (jSONArray.length() <= 0) {
            return "";
        }
        String string2 = jSONArray.toString();
        if (!TextUtils.isEmpty(string2)) {
            try {
                string = URLEncoder.encode(Helper.guulam(context, string2), "UTF-8");
            } catch (Exception e2) {
                e2.printStackTrace();
            }
        }
        return requestUploadLog(context, string);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void cleanLogFile(Context context) throws Throwable {
        LogFileUtils.saveLogToFile(context, "");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void saveLogToFile(Context context, Queue<String> queue, int i) throws Throwable {
        String strEneulret;
        JSONArray jSONArray = new JSONArray();
        if (queue != null && !queue.isEmpty()) {
            Iterator<String> it = queue.iterator();
            int i2 = 0;
            while (it.hasNext()) {
                try {
                    JSONObject jSONObject = new JSONObject(it.next());
                    if (i != -1 || jSONObject.getInt("rt") != 0) {
                        jSONArray.put(jSONObject);
                        i2++;
                        if (i2 > 10) {
                            break;
                        }
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }
        if (jSONArray.length() > 0) {
            try {
                strEneulret = Helper.eneulret(jSONArray.toString());
            } catch (Exception e2) {
                e2.printStackTrace();
                strEneulret = null;
            }
        } else {
            strEneulret = "";
        }
        if (TextUtils.isEmpty(strEneulret)) {
            return;
        }
        LogFileUtils.saveLogToFile(context, strEneulret);
    }
}
