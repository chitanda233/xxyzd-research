package cn.thinkingdata.analytics.h;

import android.text.TextUtils;
import cn.thinkingdata.core.preset.TDPresetUtils;
import cn.thinkingdata.core.utils.TDLog;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Date;
import java.util.Iterator;
import java.util.regex.Pattern;
import kotlin.jvm.internal.ByteCompanionObject;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final Pattern f117a = Pattern.compile("^[a-zA-Z][a-zA-Z\\d_]{0,49}$", 2);
    private static final ArrayList<String> b = new a();

    class a extends ArrayList<String> {
        a() {
            add(TDPresetUtils.KEY_BUNDLE_ID);
            add("#duration");
            add("#ops_receipt_properties");
        }
    }

    public static boolean a(String str) {
        return str == null || !f117a.matcher(str).matches();
    }

    public static boolean a(JSONObject jSONObject) {
        if (jSONObject == null || !TDLog.mEnableLog) {
            return true;
        }
        Iterator<String> itKeys = jSONObject.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            if (TextUtils.isEmpty(next)) {
                TDLog.w("ThinkingAnalytics.PropertyUtils", "Empty property name is not allowed.");
            }
            if (!f117a.matcher(next).matches() && !b.contains(next)) {
                TDLog.w("ThinkingAnalytics.PropertyUtils", "[ThinkingData] Warning: Incorrect properties name[" + next + "]. The property KEY must be string that starts with English letter, and contains letter, number, and '_'. The max length of the property KEY is 50. ");
            }
            try {
                Object obj = jSONObject.get(next);
                if (!(obj instanceof String) && !(obj instanceof Number) && !(obj instanceof Boolean) && !(obj instanceof Date) && !(obj instanceof JSONArray) && !(obj instanceof JSONObject)) {
                    TDLog.w("ThinkingAnalytics.PropertyUtils", "[ThinkingData] Warning: Property value must be type String, Number, Boolean, Date, JSONObject or JSONArray");
                }
                if (obj instanceof Number) {
                    double dDoubleValue = ((Number) obj).doubleValue();
                    if (dDoubleValue > 9.999999999999998E12d || dDoubleValue < -9.999999999999998E12d) {
                        TDLog.w("ThinkingAnalytics.PropertyUtils", "[ThinkingData] Warning: The number value [" + obj + "] is invalid.");
                    }
                }
            } catch (JSONException e) {
                TDLog.e("ThinkingAnalytics.PropertyUtils", "Unexpected parameters." + e);
                return false;
            }
        }
        return true;
    }

    public static byte[] a(String str, int i) throws UnsupportedEncodingException {
        int i2;
        int i3;
        byte b2;
        byte[] bytes = str.getBytes("UTF-8");
        if (bytes.length <= i) {
            return bytes;
        }
        if ((bytes[i] & ByteCompanionObject.MIN_VALUE) == 0) {
            return Arrays.copyOf(bytes, i);
        }
        int i4 = 0;
        while (true) {
            i2 = i - i4;
            i3 = i2 - 1;
            b2 = bytes[i3];
            if ((b2 & ByteCompanionObject.MIN_VALUE) <= 0 || (b2 & 64) != 0) {
                break;
            }
            i4++;
        }
        return (b2 & ByteCompanionObject.MIN_VALUE) > 0 ? Arrays.copyOf(bytes, i3) : Arrays.copyOf(bytes, i2);
    }
}
