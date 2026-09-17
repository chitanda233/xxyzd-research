package cn.thinkingdata.core.utils;

import android.content.Context;
import android.text.TextUtils;
import cn.thinkingdata.core.TDSettings;
import com.alipay.sdk.app.AlipayApi;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDCommonUtil {
    public static List<TDSettings> getConfigFromAssets(Context context) {
        String jsonFromAssets = getJsonFromAssets("td_settings.json", context);
        ArrayList arrayList = new ArrayList();
        try {
            JSONArray jSONArray = new JSONArray(jsonFromAssets);
            for (int i = 0; i < jSONArray.length(); i++) {
                JSONObject jSONObject = jSONArray.getJSONObject(i);
                if (jSONObject != null) {
                    TDSettings tDSettings = new TDSettings();
                    tDSettings.appId = jSONObject.optString(AlipayApi.c);
                    tDSettings.serverUrl = jSONObject.optString("serverUrl");
                    if (!TextUtils.isEmpty(tDSettings.appId) && !TextUtils.isEmpty(tDSettings.serverUrl)) {
                        tDSettings.instanceName = jSONObject.optString("instanceName");
                        tDSettings.mode = TDSettings.TDMode.values()[jSONObject.optInt("mode")];
                        double dOptDouble = jSONObject.optDouble("defaultTimeZone");
                        if (dOptDouble != 0.0d) {
                            tDSettings.defaultTimeZone = TimeUtil.getTimeZone(dOptDouble);
                        }
                        tDSettings.encryptVersion = jSONObject.optInt("encryptVersion");
                        tDSettings.encryptKey = jSONObject.optString("encryptKey");
                        tDSettings.enableAutoPush = jSONObject.optBoolean("enableAutoPush");
                        tDSettings.enableAutoCalibrated = jSONObject.optBoolean("enableAutoCalibrated");
                        tDSettings.enableLog = jSONObject.optBoolean("enableLog");
                        tDSettings.rccFetchParams = jSONObject.optJSONObject("rccFetchParams");
                        arrayList.add(tDSettings);
                    }
                }
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return arrayList;
    }

    private static String getJsonFromAssets(String str, Context context) {
        StringBuilder sb = new StringBuilder();
        try {
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(context.getAssets().open(str)));
            while (true) {
                String line = bufferedReader.readLine();
                if (line == null) {
                    break;
                }
                sb.append(line);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        return sb.toString();
    }

    public static String getProp(String str, String str2) {
        try {
            Class<?> cls = Class.forName("android.os.SystemProperties");
            String str3 = (String) cls.getDeclaredMethod("get", String.class).invoke(cls, str);
            return TextUtils.isEmpty(str3) ? str2 : str3;
        } catch (Throwable th) {
            TDLog.i("TA.SystemProperties", th.getMessage());
            return str2;
        }
    }
}
