package cn.com.chinatelecom.account.api.net;

import android.content.Context;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.encrypt.Xor;
import cn.com.chinatelecom.account.api.manager.ThreadPoolManager;
import cn.com.chinatelecom.account.api.manager.WorkTask;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.com.chinatelecom.account.api.utils.DeviceInfoUtil;
import cn.com.chinatelecom.account.api.utils.LogUtils;
import cn.com.chinatelecom.account.api.utils.NetUtil;
import cn.com.chinatelecom.account.api.utils.ResultUtils;
import com.baidu.mobads.sdk.internal.cb;
import java.net.InetAddress;

/* JADX INFO: loaded from: classes.dex */
public class DnsUtils {
    private static long MIN_30 = 1800000;
    private static final String TAG = "DnsUtils";
    private static long expiredTime;
    private static String ipAddress;

    public static void init(final Context context) {
        if (ipAddress == null && NetUtil.getPreLoginDomainName() == null) {
            new ThreadPoolManager().executeTask(new WorkTask() { // from class: cn.com.chinatelecom.account.api.net.DnsUtils.1
                @Override // cn.com.chinatelecom.account.api.manager.WorkTask
                public void runTask() {
                    try {
                        String requestId = DeviceInfoUtil.getRequestId();
                        LogUtils.build(requestId).setDeviceId(DeviceInfoUtil.getDeviceId(context)).setApiFlag("dns").setNetState(NetUtil.getNetStateForLog(context));
                        String strDe = Xor.de(Constants.paramsId6Domain);
                        String inetAddress = DnsUtils.getInetAddress(strDe, requestId, 0);
                        if (TextUtils.isEmpty(inetAddress)) {
                            inetAddress = DnsUtils.getInetAddress(strDe, requestId, 1);
                        }
                        synchronized (DnsUtils.class) {
                            if (!TextUtils.isEmpty(inetAddress)) {
                                DnsUtils.ipAddress = inetAddress;
                                DnsUtils.expiredTime = System.currentTimeMillis() + DnsUtils.MIN_30;
                                LogUtils.build(requestId).setResult(0).setMsg(cb.o);
                            } else {
                                LogUtils.build(requestId).setResult(ResultUtils.CODE_INIT_DNS_FAIL).setMsg(Xor.de(ResultUtils.MSG_INIT_DNS_FAIL));
                            }
                        }
                        LogUtils.appendInitLog(requestId);
                    } catch (Throwable th) {
                        th.printStackTrace();
                    }
                }
            });
        }
    }

    public static synchronized String getPreLoginIpv4Addr() {
        if (System.currentTimeMillis() >= expiredTime || !DeviceInfoUtil.isIpv4Addr(ipAddress)) {
            return null;
        }
        return ipAddress;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static String getInetAddress(String str, String str2, int i) {
        String str3;
        try {
            LogUtils.build(str2).setRetryCount(i);
            return InetAddress.getByName(str).getHostAddress();
        } catch (Exception e) {
            if (i == 0) {
                str3 = "first exception: " + e.getMessage();
            } else {
                str3 = "retry exception: " + e.getMessage();
            }
            LogUtils.build(str2).putException(str3);
            return null;
        }
    }
}
