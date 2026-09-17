package com.tencent.turingfd.sdk.ams.ad;

import java.io.File;
import java.io.FileFilter;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes4.dex */
public final class Andromeda implements FileFilter {
    @Override // java.io.FileFilter
    public final boolean accept(File file) {
        return Pattern.matches("cpu[0-9]", file.getName());
    }
}
