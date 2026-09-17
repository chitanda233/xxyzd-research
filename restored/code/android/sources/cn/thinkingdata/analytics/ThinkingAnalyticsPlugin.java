package cn.thinkingdata.analytics;

import android.content.Context;
import android.text.TextUtils;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.core.TDSettings;
import cn.thinkingdata.core.router.plugin.IPlugin;
import cn.thinkingdata.core.router.plugin.MethodCall;
import com.alipay.sdk.app.AlipayApi;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class ThinkingAnalyticsPlugin implements IPlugin {
    private k getDataType(MethodCall methodCall) {
        String str = methodCall.method;
        if (TextUtils.equals(str, "track")) {
            return k.TRACK;
        }
        if (TextUtils.equals(str, "userSet")) {
            return k.USER_SET;
        }
        return null;
    }

    @Override // cn.thinkingdata.core.router.plugin.IPlugin
    public void onMethodCall(MethodCall methodCall) {
        try {
            String str = methodCall.method;
            if (!TextUtils.equals(str, "track") && !TextUtils.equals(str, "userSet")) {
                if (TextUtils.equals(str, "init")) {
                    Context context = (Context) methodCall.argument("context");
                    List<TDSettings> list = (List) methodCall.argument("settings");
                    if (context != null && list != null) {
                        for (TDSettings tDSettings : list) {
                            if (TextUtils.isEmpty(tDSettings.instanceName)) {
                                tDSettings.instanceName = tDSettings.appId;
                            }
                            TDConfig tDConfig = TDConfig.getInstance(context, tDSettings.appId, tDSettings.serverUrl, tDSettings.instanceName);
                            if (tDSettings.mode != null) {
                                tDConfig.setMode(TDConfig.TDMode.values()[tDSettings.mode.ordinal()]);
                            }
                            if (tDSettings.defaultTimeZone != null) {
                                tDConfig.setDefaultTimeZone(tDSettings.defaultTimeZone);
                            }
                            if (tDSettings.encryptVersion > 0 && !TextUtils.isEmpty(tDSettings.encryptKey)) {
                                tDConfig.enableEncrypt(tDSettings.encryptVersion, tDSettings.encryptKey);
                            }
                            tDConfig.enableAutoCalibrated = tDSettings.enableAutoCalibrated;
                            if (tDSettings.sslSocketFactory != null) {
                                tDConfig.setSSLSocketFactory(tDSettings.sslSocketFactory);
                            }
                            TDAnalytics.enableLog(tDSettings.enableLog);
                            TDAnalytics.init(tDConfig);
                        }
                        return;
                    }
                    return;
                }
                return;
            }
            String str2 = (String) methodCall.argument(AlipayApi.c);
            JSONObject jSONObject = (JSONObject) methodCall.argument("properties");
            int iIntValue = methodCall.hasKey("from") ? ((Integer) methodCall.argument("from")).intValue() : -1;
            String str3 = (String) methodCall.argument("eventName");
            int iIntValue2 = ((Integer) methodCall.argument("trackDebugType")).intValue();
            cn.thinkingdata.analytics.h.r.a aVar = new cn.thinkingdata.analytics.h.r.a();
            aVar.d = str2;
            aVar.b = str3;
            aVar.c = jSONObject;
            aVar.e = iIntValue;
            aVar.f129a = getDataType(methodCall);
            aVar.f = iIntValue2;
            cn.thinkingdata.analytics.h.r.b.a(aVar);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
