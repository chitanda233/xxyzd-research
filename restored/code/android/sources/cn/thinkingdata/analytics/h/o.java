package cn.thinkingdata.analytics.h;

import android.os.SystemClock;
import cn.thinkingdata.core.utils.TimeUtil;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;
import java.util.TimeZone;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes.dex */
public class o implements e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final long f124a = SystemClock.elapsedRealtime();
    private final TimeZone b;
    private final d c;
    private Date d;

    public o(d dVar, TimeZone timeZone) {
        this.c = dVar;
        this.b = timeZone;
    }

    @Override // cn.thinkingdata.analytics.h.e
    public Double a() {
        return Double.valueOf(q.a(c().getTime(), this.b));
    }

    @Override // cn.thinkingdata.analytics.h.e
    public String b() {
        try {
            SimpleDateFormat simpleDateFormat = new SimpleDateFormat(TimeUtil.TIME_PATTERN, Locale.CHINA);
            simpleDateFormat.setTimeZone(this.b);
            String str = simpleDateFormat.format(c());
            return !Pattern.compile("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}\\.\\d{3}").matcher(str).find() ? q.a(c(), this.b) : str;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public synchronized Date c() {
        if (this.d == null) {
            this.d = this.c.a(this.f124a);
        }
        return this.d;
    }
}
