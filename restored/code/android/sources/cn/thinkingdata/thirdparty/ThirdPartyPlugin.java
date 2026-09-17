package cn.thinkingdata.thirdparty;

import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.core.router.plugin.IPlugin;
import cn.thinkingdata.core.router.plugin.MethodCall;

/* JADX INFO: loaded from: classes.dex */
public class ThirdPartyPlugin implements IPlugin {
    @Override // cn.thinkingdata.core.router.plugin.IPlugin
    public void onMethodCall(MethodCall methodCall) {
        String str = methodCall.method;
        str.hashCode();
        if (str.equals("enableThirdPartySharing")) {
            TAThirdPartyManager.enableThirdPartySharing(((Integer) methodCall.argument("type")).intValue(), (ThinkingAnalyticsSDK) methodCall.argument("instance"), (String) methodCall.argument("loginId"));
        } else if (str.equals("enableThirdPartySharingWithParams")) {
            TAThirdPartyManager.enableThirdPartySharing(((Integer) methodCall.argument("type")).intValue(), (ThinkingAnalyticsSDK) methodCall.argument("instance"), (String) methodCall.argument("loginId"), methodCall.argument("params"));
        }
    }
}
